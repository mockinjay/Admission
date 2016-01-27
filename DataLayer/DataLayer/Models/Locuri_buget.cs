using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Locuri_buget
    {
        public Nullable<decimal> ID_Specializare { get; set; }
        public Nullable<decimal> ID_Beneficiar { get; set; }
        public Nullable<decimal> Nr_locuri { get; set; }
        public Nullable<decimal> Din_care_fete { get; set; }
        public int ID { get; set; }
        public virtual Beneficiari Beneficiari { get; set; }
        public virtual Specializari Specializari { get; set; }
    }
}
