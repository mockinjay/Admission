using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Olimpici
    {
        public decimal ID_Olimpic { get; set; }
        public Nullable<decimal> ID_Candidat { get; set; }
        public virtual Candidati Candidati { get; set; }
    }
}
