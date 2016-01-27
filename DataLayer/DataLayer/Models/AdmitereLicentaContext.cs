using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataLayer.Models.Mapping;

namespace DataLayer.Models
{
    public partial class AdmitereLicentaContext : DbContext
    {
        static AdmitereLicentaContext()
        {
            Database.SetInitializer<AdmitereLicentaContext>(null);
        }

        public AdmitereLicentaContext()
            : base("Name=AdmitereLicentaContext")
        {
        }

        public DbSet<Beneficiari> Beneficiaris { get; set; }
        public DbSet<Candidati> Candidatis { get; set; }
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Facultati> Facultatis { get; set; }
        public DbSet<Locuri_buget> Locuri_buget { get; set; }
        public DbSet<Locuri_taxa> Locuri_taxa { get; set; }
        public DbSet<Olimpici> Olimpicis { get; set; }
        public DbSet<Optiuni> Optiunis { get; set; }
        public DbSet<Probe> Probes { get; set; }
        public DbSet<Programare_examen> Programare_examen { get; set; }
        public DbSet<Rezultate_probe> Rezultate_probe { get; set; }
        public DbSet<Sali_admitere> Sali_admitere { get; set; }
        public DbSet<Specializari> Specializaris { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Utilizatori> Utilizatoris { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BeneficiariMap());
            modelBuilder.Configurations.Add(new CandidatiMap());
            modelBuilder.Configurations.Add(new DepartamentMap());
            modelBuilder.Configurations.Add(new FacultatiMap());
            modelBuilder.Configurations.Add(new Locuri_bugetMap());
            modelBuilder.Configurations.Add(new Locuri_taxaMap());
            modelBuilder.Configurations.Add(new OlimpiciMap());
            modelBuilder.Configurations.Add(new OptiuniMap());
            modelBuilder.Configurations.Add(new ProbeMap());
            modelBuilder.Configurations.Add(new Programare_examenMap());
            modelBuilder.Configurations.Add(new Rezultate_probeMap());
            modelBuilder.Configurations.Add(new Sali_admitereMap());
            modelBuilder.Configurations.Add(new SpecializariMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UtilizatoriMap());
        }
    }
}
