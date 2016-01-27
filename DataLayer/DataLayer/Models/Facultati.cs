using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Facultati
    {
        public Facultati()
        {
            this.Departaments = new List<Departament>();
        }

        public decimal ID_Facultate { get; set; }
        public string Nume_facultate { get; set; }
        public virtual ICollection<Departament> Departaments { get; set; }
    }
}
