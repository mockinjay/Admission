using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using System.Data.Entity;
using System.Transactions;

namespace DataLayer
{
   
    public class DataTier
    {
        int currentUser;
        public DataTier()
        {
            currentUser = 4;
        }


        public IEnumerable<Facultati> ReadFaculties()
        {
            using (var context = new AdmitereLicentaContext())
            {
                var fac = (from n in context.Facultatis
                           select n).ToList<Facultati>();
                return fac;
            }


        }
        public IEnumerable<Departament> ReadDepartments(int facultyId)
        {
            using (var context = new AdmitereLicentaContext())
            {
                var department = context.Departaments.Where(n => n.ID_Facultate == facultyId).ToList();
                return department;
            }
        }

        public IEnumerable<Specializari> ReadSpecialization(int departementId)
        {
            using (var context = new AdmitereLicentaContext())
            {
                var specialization = context.Specializaris.Where(n => n.ID_Departament == departementId).ToList();
                return specialization;
            }

        }

        public string CheckUser(string email, string password)
        {
            using (var context = new AdmitereLicentaContext())
            {
                var user = (from c in context.Candidatis
                            where c.Email == email
                            select c.ID_Candidat
                   ).SingleOrDefault();

                if (user == 0)
                {
                    return "WrongUser";
                }
                else
                {
                    var pass = (from c in context.Utilizatoris
                                where c.ID_Candidat == user && c.Parola == password
                                select c.Parola

                                ).SingleOrDefault();
                    if (pass == null)
                    {
                        return "WrongPassword";
                    }
                    else
                    {
                        currentUser = Decimal.ToInt32(user);
                        return "Corect";
                    }
                }


            }
        }
        public Candidati ReadUserDetails(string email)
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = context.Candidatis.Where(n => n.Email == email && n.ID_Candidat == currentUser).ToList<Candidati>().FirstOrDefault();
                return query;
            }
        }
        public Candidati ReadUserDetails()
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = context.Candidatis.Where(n => n.ID_Candidat == currentUser).ToList<Candidati>().FirstOrDefault();
                return query;
            }
        }

        public IEnumerable<Utilizatori> ReadPassword(string email)
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = from n in context.Candidatis
                            join u in context.Utilizatoris
                             on n.ID_Candidat equals u.ID_Candidat
                            where n.Email == email
                            select u;
                return query.ToList();
            }
        }

        public IEnumerable<Beneficiari> ReadAllBeneficiari()
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = context.Beneficiaris;
                return query.ToList();
            }
        }
        public Locuri_buget ReadLocuriBuget(int specializationID, int beneficiarID)
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = context.Locuri_buget.Where(n => n.ID_Beneficiar == beneficiarID && n.ID_Specializare == specializationID).ToList().FirstOrDefault();
                return query;
            }
        }


        public IEnumerable<Locuri_taxa> ReadLocuriTaxa(int specialization)
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = context.Locuri_taxa.Where(n => n.ID_Specializare == specialization).ToList();
                return query;
            }
        }

        public string AddUserOption(string specializare, int prioritate, string isTaxa)
        {
            using (var context = new AdmitereLicentaContext())
            {
                
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {

                        var q = (from c in context.Specializaris
                                 where c.Nume_specializare == specializare
                                 select c.ID_Specializare).FirstOrDefault();
                        if ( q == 0)
                        {
                            return "NoSpecialization";
                        }
                        var query = context.Optiunis;
                        foreach (var temp in query)
                        {
                            if (temp.ID_Specializare == q)
                            {
                                return "SpecializationExist";
                            }
                        }
                        var query2 = this.GetUserOptionOrderedByPriority();
                        bool flag = false;
                        foreach(var temp in query2)
                        {
                            if (temp.Prioritate == prioritate)
                            {
                                flag = true; ;
                            }
                            if (flag==true)
                            {
                                temp.Prioritate++;
                                this.UpdateUserOption(temp);
                            }

                        }
                        //var query = context.Specializaris.Where(n => n.Nume_specializare == specializare).First();
                        currentUser = 4;
                        var cand = this.GetCurrentUser();
                        var spec = context.Specializaris.Where(n => n.Nume_specializare == specializare).FirstOrDefault();
                        var option = new Optiuni();
                        option.ID_Candidat = 4;
                        option.Prioritate = prioritate;
                        option.Doreste_Taxa = isTaxa;
                        option.ID_Specializare = q;
                        option.Candidati = cand;
                        option.Specializari = spec;
                        context.Optiunis.Add(option);
                        context.Entry(option).State = System.Data.Entity.EntityState.Added;
                        context.SaveChanges();
                        transaction.Commit();
                        return "TransactionCorect";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return "TransactionFailed ad";
                    }

                }
            }

        }
        public IEnumerable<Optiuni> ReadUserOption()
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = context.Optiunis.Where(n => n.ID_Candidat == currentUser).ToList<Optiuni>();
                return query;
            }
        }
        
        public bool DeleteUserOption(string specializare)
        {
            using (var context = new AdmitereLicentaContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var query = (from n in context.Specializaris
                                     join u in context.Optiunis
                                      on n.ID_Specializare equals u.ID_Specializare
                                     where n.Nume_specializare == specializare
                                     select u).ToList<Optiuni>().FirstOrDefault();
                        if (query != null)
                        {
                            context.Optiunis.Remove(query);
                            context.Entry(query).State = System.Data.Entity.EntityState.Deleted;
                            context.SaveChanges();
                            transaction.Commit();
                            return true;
                        }
                        else
                            return false;


                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }

            }
        }
        public bool UpdateUserOption(Optiuni _optiune)
        {
            using (var context = new AdmitereLicentaContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Optiunis.Add(_optiune);
                        context.Entry(_optiune).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
        public bool UpdateUserOption(int priority, string specialization)
        {
            using (var context = new AdmitereLicentaContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var query = (from n in context.Candidatis
                                     join u in context.Optiunis
                                     on n.ID_Candidat equals u.ID_Candidat
                                     join x in context.Specializaris
                                     on u.ID_Specializare equals x.ID_Specializare
                                     where n.ID_Candidat == currentUser && x.Nume_specializare == specialization
                                     select u).ToList<Optiuni>().FirstOrDefault();
                        if (query != null)
                        {
                            query.Prioritate = Convert.ToDecimal(priority);
                            context.Optiunis.Add(query);
                            context.Entry(query).State = System.Data.Entity.EntityState.Modified;
                            context.SaveChanges();
                            transaction.Commit();
                            return true;
                        }
                        else
                            return false;
                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
        
        public void LogOut()
        {
            currentUser = 0;
        }

        public bool DeleteUserOption(int specID)
        {
            using (var context = new AdmitereLicentaContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var query = (from n in context.Specializaris
                                     join u in context.Optiunis
                                      on n.ID_Specializare equals u.ID_Specializare
                                     where n.ID_Specializare == specID
                                     select u).ToList<Optiuni>().FirstOrDefault();
                        if (query != null)
                        {
                            context.Optiunis.Remove(query);
                            context.Entry(query).State = System.Data.Entity.EntityState.Deleted;
                            context.SaveChanges();
                            transaction.Commit();
                            return true;
                        }
                        else
                            return false;


                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }

            }
        }
        public bool DeleteUser()
        {
            using (var context = new AdmitereLicentaContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var query = context.Candidatis.Where(n => n.ID_Candidat == currentUser).ToList<Candidati>().FirstOrDefault();


                        if (query != null)
                        {
                            context.Candidatis.Remove(query);
                            context.Entry(query).State = System.Data.Entity.EntityState.Deleted;
                            context.SaveChanges();
                            transaction.Commit();
                            return true;
                        }
                        else
                            return false;

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
        public IEnumerable<Optiuni> GetUserOptionOrderedByPriority()
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = (from n in context.Optiunis
                             where n.ID_Candidat == currentUser
                             select n).ToList<Optiuni>();
                return query;
            }
        }
        public string CreateUser(Dictionary<string, string> user)
        {
            using (var context = new AdmitereLicentaContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var query = context.Candidatis.Where(n => n.CNP == Convert.ToDecimal(user["cnp"])).FirstOrDefault();
                        if (query == null)
                        {
                            var newUser = new Candidati();
                            newUser.Nume = user["nume"];
                            newUser.Prenume = user["prenume"];
                            newUser.CNP = Convert.ToDecimal(user["cnp"]);
                            newUser.Sex = user["sex"];
                            newUser.Adresa = user["adresa"];
                            newUser.Oras = user["oras"];
                            newUser.Judet = user["judet"];
                            newUser.Nr_telefon = Convert.ToDecimal(user["telefon"]);
                            newUser.Nationalitate = user["nationalitate"];
                            newUser.Religie = user["religie"];
                            newUser.Email = user["email"];
                            newUser.Nota_BAC = Convert.ToDecimal(user["bac"]);
                            context.Candidatis.Add(newUser);
                            context.Entry(newUser).State = System.Data.Entity.EntityState.Added;
                            context.SaveChanges();
                            transaction.Commit();
                            return "SuccessAdded";
                        }
                        else
                            return "UserExists";

                        
                        

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return "TransactionFailed";
                    }

                }
            }


        }
        public bool ChangePassword(string email, string oldPass, string newPass)
        {
            using (var context = new AdmitereLicentaContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var query = (from n in context.Candidatis
                                     join u in context.Utilizatoris
                                     on n.ID_Candidat equals u.ID_Candidat

                                     where n.Email == email && u.Parola == oldPass && n.ID_Candidat == currentUser


                                     select u
                            ).ToList<Utilizatori>().FirstOrDefault();
                        if (query != null)
                        {
                            query.Parola = newPass;
                            context.Utilizatoris.Add(query);
                            context.Entry(query).State = System.Data.Entity.EntityState.Modified;
                            context.SaveChanges();
                            transaction.Commit();
                            return true;
                        }
                        else
                            return false;


                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
        public IEnumerable<Candidati>ReadAllOlimpici()
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = from n in context.Candidatis
                            join u in context.Olimpicis
                            on n.ID_Candidat equals u.ID_Candidat
                            select n;
                return query.ToList<Candidati>();
            }
        }
        public IEnumerable<Rezultate_probe> ReadRezultate(int proba)
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = from u in context.Rezultate_probe
                            where u.ID_Proba == proba
                            select u;

                query.OrderBy(n => n.ID_Proba).ThenByDescending(n => n.Nota).ToList();
                return query.ToList<Rezultate_probe>();
            }
        }

        public IEnumerable<Rezultate_probe> ReadTestsResult()
        {
            using (var contest = new AdmitereLicentaContext())
            {
                //var query = (from n in contest.Rezultate_probe
                //             join p in contest.Probes
                //             on n.ID_Proba equals p.ID_Proba
                //             where n.ID_Candidat == currentUser
                //             select new { p.Nume_Proba, n.Nota }
                //    ).ToList();
                var query = contest.Rezultate_probe.Where(n => n.ID_Candidat == currentUser).ToList<Rezultate_probe>();
                return query;
            }

        }

        public IEnumerable<Probe> ReadTest()
        {
            using (var contest = new AdmitereLicentaContext())
            {
                var query = contest.Probes.ToList<Probe>();
                return query;
            }
        }


        //sergiu

        public bool UpdateUserDetails(Candidati temp)
        {
            using (var context = new AdmitereLicentaContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Candidatis.Add(temp);
                        context.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }

        }
    }
}

