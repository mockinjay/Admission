using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Candidati
    {
        public Candidati()
        {
            this.Programare_examen = new List<Programare_examen>();
            this.Rezultate_probe = new List<Rezultate_probe>();
            this.Olimpicis = new List<Olimpici>();
            this.Optiunis = new List<Optiuni>();
            this.Utilizatoris = new List<Utilizatori>();
        }

        public  decimal ID_Candidat { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public Nullable<decimal> CNP { get; set; }
        public string Sex { get; set; }
        public string Adresa { get; set; }
        public string Oras { get; set; }
        public string Judet { get; set; }
        public Nullable<decimal> Nr_telefon { get; set; }
       // public string Tara { get; set; }
        public string Nationalitate { get; set; }
        public string Religie { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> Nota_BAC { get; set; }
        public virtual ICollection<Programare_examen> Programare_examen { get; set; }
        public virtual ICollection<Rezultate_probe> Rezultate_probe { get; set; }
        public virtual ICollection<Olimpici> Olimpicis { get; set; }
        public virtual ICollection<Optiuni> Optiunis { get; set; }
        public virtual ICollection<Utilizatori> Utilizatoris { get; set; }
    }
}
