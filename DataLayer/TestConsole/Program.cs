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
           // checkUser();
            //getPass();
            //getloc();
            //delOp();
            //updateop();
            addUseroption();
        }

        private static void addUseroption()
        {
            string result = dt.AddUserOption("Armament, aparatură artileristică şi sisteme de conducere  a focului", 2, "nu");
            Console.WriteLine(result);
        }

        private static void updateop()
        {
            bool flag = dt.UpdateUserOption(1, "Calculatoare şi sisteme informatice pentru apărare şi securitate naţională");
            if (flag == true)
            {
                Console.WriteLine("OK");
            }
            else
                Console.WriteLine("Prost");
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
            Locuri_buget loc = dt.ReadLocuriBuget(14, 1);
            if (loc!=null)
            {
              
                    Console.Write(loc.ID_Beneficiar);
                    Console.Write(": ");
                    Console.Write(loc.Nr_locuri.ToString());
                
            }
        }
        private static void checkUser()
        {
            String temp = dt.CheckUser("sas@gmail.com", "admin");
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
