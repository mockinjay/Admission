using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Optiuni
    {
        public Nullable<decimal> ID_Specializare { get; set; }
        public Nullable<decimal> ID_Candidat { get; set; }
        public Nullable<decimal> Prioritate { get; set; }
        public string Doreste_Taxa { get; set; }
        public int ID { get; set; }
        public virtual Candidati Candidati { get; set; }
        public virtual Specializari Specializari { get; set; }
    }
}
