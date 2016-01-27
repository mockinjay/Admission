using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Departament
    {
        public Departament()
        {
            this.Specializaris = new List<Specializari>();
        }

        public decimal ID_Departament { get; set; }
        public string Nume_departament { get; set; }
        public Nullable<decimal> ID_Facultate { get; set; }
        public virtual ICollection<Specializari> Specializaris { get; set; }
        public virtual Facultati Facultati { get; set; }
    }
}
