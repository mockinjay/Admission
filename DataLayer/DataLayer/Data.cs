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
        
        private bool disposed;
        int currentUser;
        public DataTier()
        {
            
            currentUser = 0;
        }
       
        public IDbSet<Facultati> readFaculties()
        {
            using (var context = new AdmitereLicentaContext())
            {
                var fac = context.Facultatis;
                return fac;
            }
                
            
        }
        public IEnumerable<Departament> readDepartments(int facultyId)
        {
            using (var context = new AdmitereLicentaContext())
            {
                var department = context.Departaments.Where(n => n.ID_Facultate == facultyId).ToList();
                return department;
            }
        }

        public IEnumerable<Specializari> readSpecialization(int departementId)
        {
            using (var context = new AdmitereLicentaContext())
            {
                var specialization = context.Specializaris.Where(n => n.ID_Departament == departementId).ToList();
                return specialization;
            }
                
        }

        public string checkUser(string email, string password)
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
        public IEnumerable<Utilizatori> getPassword(string email)
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

        public IEnumerable<Beneficiari> readAllBeneficiari()
        {
            using (var context=new AdmitereLicentaContext())
            {
                var query = context.Beneficiaris;
                return query.ToList();
            }
        }
        public IEnumerable<Locuri_buget> readLocuriBuget(int specializationID, int beneficiarID)
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = context.Locuri_buget.Where(n => n.ID_Beneficiar == beneficiarID && n.ID_Specializare == specializationID).ToList();
                return query;
            }
        }

        public IEnumerable<Locuri_taxa> readLocuriTaxa(int specialization)
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = context.Locuri_taxa.Where(n => n.ID_Specializare == specialization).ToList() ;
                return query;
            }
        }

        public string AddUserOption(string specializare,int prioritate, string isTaxa )
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
                        if (q==null || q==0)
                        {
                            return "NoSpecialization";
                        }
                        var query = context.Optiunis;
                        foreach(var temp in query)
                        {
                            if (temp.ID_Specializare==q)
                            {
                                return "SpecializationExist";
                            }
                            if (temp.Prioritate==prioritate)
                            {
                                return "ThisPriorityExists";
                            }  

                        }
                        
                        //var query = context.Specializaris.Where(n => n.Nume_specializare == specializare).First();

                        var option = new Optiuni();
                        option.ID_Candidat = currentUser;
                        option.Prioritate = prioritate;
                        option.Doreste_Taxa = isTaxa;
                        option.ID_Specializare = q;
                        context.Optiunis.Add(option);
                        context.Entry(option).State = System.Data.Entity.EntityState.Added;
                        context.SaveChanges();
                        transaction.Commit();
                        return "TransactionCorect";
                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                        return "TransactionFailed";
                    }
                    
                }
            }
                
        }
        public IEnumerable<Optiuni> getUserOptionOrderedByPriority()
        {
            using (var context = new AdmitereLicentaContext())
            {
                var query = context.Optiunis.OrderBy(n => n.Prioritate).ToList();
                return query;
            }
        }
        public void createUser(Dictionary<string, string> user)
        {
            using (var context = new AdmitereLicentaContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
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
                        newUser.Tara = user["tara"];
                        newUser.Nationalitate = user["nationalitate"];
                        newUser.Religie = user["religie"];
                        newUser.Email = user["email"];
                        newUser.Nota_BAC = Convert.ToDecimal(user["bac"]);
                        context.Candidatis.Add(newUser);
                        context.Entry(newUser).State = System.Data.Entity.EntityState.Added;
                        context.SaveChanges();
                        transaction.Commit();
                        
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }

                }
            }
            
           
        }

    }

}
