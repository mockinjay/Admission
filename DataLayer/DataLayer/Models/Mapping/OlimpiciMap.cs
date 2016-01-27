using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class OlimpiciMap : EntityTypeConfiguration<Olimpici>
    {
        public OlimpiciMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Olimpic);

            // Properties
            this.Property(t => t.ID_Olimpic)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Olimpici");
            this.Property(t => t.ID_Olimpic).HasColumnName("ID_Olimpic");
            this.Property(t => t.ID_Candidat).HasColumnName("ID_Candidat");

            // Relationships
            this.HasOptional(t => t.Candidati)
                .WithMany(t => t.Olimpicis)
                .HasForeignKey(d => d.ID_Candidat);

        }
    }
}
