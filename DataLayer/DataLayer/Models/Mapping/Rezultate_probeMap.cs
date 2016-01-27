using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class Rezultate_probeMap : EntityTypeConfiguration<Rezultate_probe>
    {
        public Rezultate_probeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Rezultate_probe");
            this.Property(t => t.ID_Candidat).HasColumnName("ID_Candidat");
            this.Property(t => t.ID_Proba).HasColumnName("ID_Proba");
            this.Property(t => t.Nota).HasColumnName("Nota");
            this.Property(t => t.ID).HasColumnName("ID");

            // Relationships
            this.HasOptional(t => t.Candidati)
                .WithMany(t => t.Rezultate_probe)
                .HasForeignKey(d => d.ID_Candidat);
            this.HasOptional(t => t.Probe)
                .WithMany(t => t.Rezultate_probe)
                .HasForeignKey(d => d.ID_Proba);

        }
    }
}
