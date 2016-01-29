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
    }
}
