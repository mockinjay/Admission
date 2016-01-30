using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer;

namespace BussinessLayer
{
    public class Bussiness
    {
        private DataTier dt;
        public Bussiness()
        {
            dt = new DataTier();
        }
        public string  CreateUser(string nume,
                                string prenume,
                                string cnp,
                                string sex,
                                string adresa,
                                string oras,
                                string judet,
                                string telefon,
                                string nationalitate,
                                string religie,
                                string email,
                                string bac)
        {
            Dictionary<string, string> addUser = new Dictionary<string, string>();
            addUser.Add("nume", nume);
            addUser.Add("prenume", prenume);
            addUser.Add("cnp", cnp);
            addUser.Add("sex", sex);
            addUser.Add("adresa", adresa);
            addUser.Add("oras", oras);
            addUser.Add("judet", judet);
            addUser.Add("telefon", telefon);
            addUser.Add("nationalitate", nationalitate);
            addUser.Add("bac", bac);
            addUser.Add("religie", religie);
            addUser.Add("email", email);
            return dt.CreateUser(addUser);
        }

        public List<Facultati> getFacultati()
        {
            var variable = dt.ReadFaculties().ToList<Facultati>();
            return variable;
        }

        public List<Departament> getDepartament(int facultyId)
        {
            var variable = dt.ReadDepartments(facultyId).ToList<Departament>();
            return variable;
        }

        public List<Specializari> getSpecializari(int departementId)
        {
            var variable = dt.ReadSpecialization(departementId).ToList<Specializari>();
            return variable;
        }

        public List<Beneficiari> getBeneficiari()
        {
            var variable = dt.ReadAllBeneficiari().ToList<Beneficiari>();
            return variable;
        }

        public List<Locuri_buget> getLocuriBuget(int specializationID, int beneficiarID)
        {
            var variable = dt.ReadLocuriBuget(specializationID,beneficiarID).ToList<Locuri_buget>();
            return variable;
        }

        public List<Locuri_taxa> getLocuriTaxa(int specialization)
        {
            var variable = dt.ReadLocuriTaxa(specialization).ToList<Locuri_taxa>();
            return variable;
        }

        public List<Optiuni> getUserOptiuns()
        {
            var variable = dt.ReadUserOption().ToList<Optiuni>();
            return variable;
        }


        public List<Optiuni> getUserOptiosPrioritized()
        {
            var variable = dt.GetUserOptionOrderedByPriority().ToList<Optiuni>();
            return variable;
        }


        public List<Candidati> getCandidatiOlimpici()
        {
            var variable = dt.ReadAllOlimpici().ToList<Candidati>();
            return variable;
        }


       public List<Rezultate_probe> getRezultateProbe(int proba)
        {
            var variable = dt.ReadRezultate(proba).ToList<Rezultate_probe>();
            return variable;
        }
        public decimal getUserID(string email)
        {
            return dt.ReadUserDetails(email).ID_Candidat;
        }
        public string getUserFirstName(string email)
        {
            return dt.ReadUserDetails(email).Prenume;
        }
        public string getUserLastName(string email)
        {
            return dt.ReadUserDetails(email).Nume;
        }
        public Nullable<decimal> getUserCNP(string email)
        {
            return dt.ReadUserDetails(email).CNP;
        }
        public string getUserSex(string email)
        {
            return dt.ReadUserDetails(email).Sex;
        }
        public string getUserAdresa(string email)
        {
            return dt.ReadUserDetails(email).Adresa;
        }
        public string getUserOras(string email)
        {
            return dt.ReadUserDetails(email).Oras;
        }
        public string getUserJudet(string email)
        {
            return dt.ReadUserDetails(email).Judet;
        }
        public Nullable<decimal> getUserNr_telefon(string email)
        {
            return dt.ReadUserDetails(email).Nr_telefon;
        }
        public string getUserTara(string email)
        {
            return dt.ReadUserDetails(email).Tara;
        }
        public string getUserNationalitate(string email)
        {
            return dt.ReadUserDetails(email).Nationalitate;
        }
        public string getUserReligie(string email)
        {
            return dt.ReadUserDetails(email).Religie;
        }
        public Nullable<decimal> getUserNota_BAC(string email)
        {
            return dt.ReadUserDetails(email).Nota_BAC;
        }
        
    }
}
