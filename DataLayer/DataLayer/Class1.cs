using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class DataTier
    {
        private readonly AdmitereLicentaContext context;
        int currentFaculty;
        private bool disposed;
        int currentUser;
        public DataTier()
        {
            context = new AdmitereLicentaContext();
            currentUser = 0;
        }

        public DataTier(AdmitereLicentaContext _context)
        {
            context = _context;

        }
        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }


        public List<Facultati> getFaculties()
        {
            List<Facultati> list = new List<Facultati>();
            var fac = context.Facultatis;
            foreach (var aux in fac)
            {
                list.Add(aux);
            }
            return list;
        }
        public List<Departament> getDepartments(int facultyId)
        {
            List<Departament> list = new List<Departament>();
            var department = context.Departaments.Where(n => n.ID_Facultate == facultyId);
            foreach (var aux in department)
            {
                list.Add(aux);
            }
            return list;
        }

        public List<Specializari> getSpecialization(int departementId)
        {
            List<Specializari> list = new List<Specializari>();
            var specialization = context.Specializaris.Where(n => n.ID_Departament == departementId);
            foreach (var _spec in specialization)
            {
                list.Add(_spec);
            }
            return list;
        }

        public string checkUser(string email, string password)
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
        public void createUser(Dictionary<string, string> user)
        {

        }

    }

}
