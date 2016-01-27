using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Probe
    {
        public Probe()
        {
            this.Programare_examen = new List<Programare_examen>();
            this.Rezultate_probe = new List<Rezultate_probe>();
        }

        public decimal ID_Proba { get; set; }
        public string Nume_Proba { get; set; }
        public virtual ICollection<Programare_examen> Programare_examen { get; set; }
        public virtual ICollection<Rezultate_probe> Rezultate_probe { get; set; }
    }
}
