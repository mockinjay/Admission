using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer;
namespace BussinessLayer
{

   

    public class Class1
    {
        
        
        //public List<Tuple<string, string, string, string, int>> GetAvailableSeats()
        //{
        //    List<Tuple<string, string, string, string, int>> retList = new List<Tuple<string, string, string, string, int>>();
        //         DataTier dt = new DataTier();
        //    IEnumerable<Facultati> fac = dt.ReadFaculties();
        //    IEnumerable<Beneficiari> ben = dt.ReadAllBeneficiari();
        //    foreach (Facultati facItem in fac)
        //    {
        //        IEnumerable<Departament> dep = dt.ReadDepartments(Convert.ToInt32(facItem.ID_Facultate));

        //        foreach (Departament depItem in dep)
        //        {
        //            IEnumerable<Specializari> spec = dt.ReadSpecialization(Convert.ToInt32(depItem.ID_Departament));
        //            foreach (Specializari specItem in spec)
        //            {
        //                foreach (Beneficiari benItem in ben)
        //                {
        //                    IEnumerable<Locuri_buget> locBug = dt.ReadLocuriBuget(Convert.ToInt32(specItem.ID_Specializare), Convert.ToInt32(benItem.ID_Beneficiar));
        //                    if (locBug != null)
        //                    {
        //                        foreach (Locuri_buget locBugItem in locBug)
        //                        {
        //                            if (locBugItem != null)
        //                            {
        //                                retList.Add(new Tuple<string, string, string, string, int>(facItem.Nume_facultate,
        //                                    depItem.Nume_departament,
        //                                    specItem.Nume_specializare,
        //                                    benItem.Nume_beneficiar,
        //                                    Convert.ToInt32(locBugItem.Nr_locuri)));
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //    }
        //    return retList;
        //}

    }


}
