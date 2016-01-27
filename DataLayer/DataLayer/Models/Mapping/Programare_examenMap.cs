using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class Programare_examenMap : EntityTypeConfiguration<Programare_examen>
    {
        public Programare_examenMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Programare_examen");
            this.Property(t => t.ID_Candidat).HasColumnName("ID_Candidat");
            this.Property(t => t.ID_Sala).HasColumnName("ID_Sala");
            this.Property(t => t.ID_Proba).HasColumnName("ID_Proba");
            this.Property(t => t.Data_ora).HasColumnName("Data_ora");
            this.Property(t => t.ID).HasColumnName("ID");

            // Relationships
            this.HasOptional(t => t.Candidati)
                .WithMany(t => t.Programare_examen)
                .HasForeignKey(d => d.ID_Candidat);
            this.HasOptional(t => t.Probe)
                .WithMany(t => t.Programare_examen)
                .HasForeignKey(d => d.ID_Proba);
            this.HasOptional(t => t.Sali_admitere)
                .WithMany(t => t.Programare_examen)
                .HasForeignKey(d => d.ID_Sala);

        }
    }
}
