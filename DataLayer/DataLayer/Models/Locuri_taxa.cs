using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Locuri_taxa
    {
        public Nullable<decimal> ID_Specializare { get; set; }
        public Nullable<decimal> Nr_locuri { get; set; }
        public int ID { get; set; }
        public virtual Specializari Specializari { get; set; }
    }
}
