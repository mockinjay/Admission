using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Sali_admitere
    {
        public Sali_admitere()
        {
            this.Programare_examen = new List<Programare_examen>();
        }

        public decimal ID_Sala { get; set; }
        public string Nume_Sala { get; set; }
        public string Pavilion { get; set; }
        public Nullable<decimal> Etaj { get; set; }
        public Nullable<decimal> Capacitate { get; set; }
        public virtual ICollection<Programare_examen> Programare_examen { get; set; }
    }
}
