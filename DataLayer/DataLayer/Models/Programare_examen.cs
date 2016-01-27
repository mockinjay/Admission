using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Programare_examen
    {
        public Nullable<decimal> ID_Candidat { get; set; }
        public Nullable<decimal> ID_Sala { get; set; }
        public Nullable<decimal> ID_Proba { get; set; }
        public Nullable<System.DateTime> Data_ora { get; set; }
        public int ID { get; set; }
        public virtual Candidati Candidati { get; set; }
        public virtual Probe Probe { get; set; }
        public virtual Sali_admitere Sali_admitere { get; set; }
    }
}
