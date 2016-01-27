using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Specializari
    {
        public Specializari()
        {
            this.Locuri_buget = new List<Locuri_buget>();
            this.Locuri_taxa = new List<Locuri_taxa>();
            this.Optiunis = new List<Optiuni>();
        }

        public decimal ID_Specializare { get; set; }
        public string Nume_specializare { get; set; }
        public Nullable<decimal> ID_Departament { get; set; }
        public virtual Departament Departament { get; set; }
        public virtual ICollection<Locuri_buget> Locuri_buget { get; set; }
        public virtual ICollection<Locuri_taxa> Locuri_taxa { get; set; }
        public virtual ICollection<Optiuni> Optiunis { get; set; }
    }
}
