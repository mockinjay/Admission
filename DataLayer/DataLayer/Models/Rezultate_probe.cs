using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Rezultate_probe
    {
        public Nullable<decimal> ID_Candidat { get; set; }
        public Nullable<decimal> ID_Proba { get; set; }
        public Nullable<decimal> Nota { get; set; }
        public int ID { get; set; }
        public virtual Candidati Candidati { get; set; }
        public virtual Probe Probe { get; set; }
    }
}
