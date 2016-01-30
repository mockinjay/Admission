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

        public List<Tuple<string, int>> ReadTestsResults()
        {
            IEnumerable<Probe> probe = dt.ReadTest();
            IEnumerable<Rezultate_probe> result = dt.ReadTestsResult();

            List<Tuple<string, int>> list = new List<Tuple<string, int>>();
            foreach (var _test in probe)
            {
                int probaID = Decimal.ToInt32(_test.ID_Proba);
                string numeProba = _test.Nume_Proba;
                var nota = (from n in result
                           where n.ID_Proba == probaID
                           select n.Nota).FirstOrDefault();
                if (nota!=null)
                {
                    list.Add(new Tuple<string, int>(numeProba,Convert.ToInt32(nota )));
                    
                }
                

            }
            return list;

        }
    }
}
