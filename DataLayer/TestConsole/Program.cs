using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;

namespace TestConsole
{
    class Program
    {
        static DataTier dt = new DataTier();
        static void Main(string[] args)
        {
            //checkUser();
            //getPass();
           // getloc();
            delOp();
        }

        private static void delOp()
        {
            bool flag = dt.ChangePassword("sas@gmail.com","isAdmin","admin");
            if (flag == true)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Prost");
        }

        private static void getloc()
        {
            IEnumerable<Locuri_buget> loc = dt.ReadLocuriBuget(1, 1);
            if (loc.Any())
            {
                foreach (var temp in loc)
                {
                    Console.Write(temp.ID_Beneficiar);
                    Console.Write(": ");
                    Console.Write(temp.Nr_locuri.ToString());
                }
            }
        }
        private static void checkUser()
        {
            String temp = dt.CheckUser("sas@gmail.com", "isAdmin");
            if (temp == "WrongUser")
            {
                Console.WriteLine("No user in the database");
            }
            else
            {
                if (temp == "WrongPassword")
                {
                    Console.WriteLine("Wrong password");
                }
                else
                    Console.WriteLine("Congratulations");
            }



        }

        private static void getPass()
        {
            IEnumerable<Utilizatori> parole = dt.ReadPassword("sas@gmail.com");
            if (parole.Any())
            {
                foreach (var temp in parole)
                {
                    Console.WriteLine(temp.Parola);
                }
            }
            else
                Console.WriteLine("No user");


        }
    }
}
