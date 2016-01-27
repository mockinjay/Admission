using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Utilizatori
    {
        public decimal ID_User { get; set; }
        public string Parola { get; set; }
        public Nullable<decimal> ID_Candidat { get; set; }
        public virtual Candidati Candidati { get; set; }
    }
}
