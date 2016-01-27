using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class ProbeMap : EntityTypeConfiguration<Probe>
    {
        public ProbeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Proba);

            // Properties
            this.Property(t => t.ID_Proba)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nume_Proba)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Probe");
            this.Property(t => t.ID_Proba).HasColumnName("ID_Proba");
            this.Property(t => t.Nume_Proba).HasColumnName("Nume_Proba");
        }
    }
}
