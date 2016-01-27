using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class OptiuniMap : EntityTypeConfiguration<Optiuni>
    {
        public OptiuniMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Doreste_Taxa)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Optiuni");
            this.Property(t => t.ID_Specializare).HasColumnName("ID_Specializare");
            this.Property(t => t.ID_Candidat).HasColumnName("ID_Candidat");
            this.Property(t => t.Prioritate).HasColumnName("Prioritate");
            this.Property(t => t.Doreste_Taxa).HasColumnName("Doreste_Taxa");
            this.Property(t => t.ID).HasColumnName("ID");

            // Relationships
            this.HasOptional(t => t.Candidati)
                .WithMany(t => t.Optiunis)
                .HasForeignKey(d => d.ID_Candidat);
            this.HasOptional(t => t.Specializari)
                .WithMany(t => t.Optiunis)
                .HasForeignKey(d => d.ID_Specializare);

        }
    }
}
