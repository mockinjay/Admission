using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;
using System.Data.Entity;

namespace BussinessLayer
{
    public class BussinessTier
    {
        private DataTier dt = new DataTier();

        public List<Facultati> readFaculties()
        {
            List<Facultati> fac = new List<Facultati>();
            IDbSet<Facultati> facultati = dt.readFaculties();
            foreach(var temp in facultati)
            {
                fac.Add(temp);
            }
            return fac;
        }
        public string checkUser(string email, string pass)
        {
            return dt.checkUser(email, pass);
        }
    }
}
