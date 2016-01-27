using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Beneficiari
    {
        public Beneficiari()
        {
            this.Locuri_buget = new List<Locuri_buget>();
        }

        public decimal ID_Beneficiar { get; set; }
        public string Nume_beneficiar { get; set; }
        public virtual ICollection<Locuri_buget> Locuri_buget { get; set; }
    }
}
