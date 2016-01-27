using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class Locuri_taxaMap : EntityTypeConfiguration<Locuri_taxa>
    {
        public Locuri_taxaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Locuri_taxa");
            this.Property(t => t.ID_Specializare).HasColumnName("ID_Specializare");
            this.Property(t => t.Nr_locuri).HasColumnName("Nr_locuri");
            this.Property(t => t.ID).HasColumnName("ID");

            // Relationships
            this.HasOptional(t => t.Specializari)
                .WithMany(t => t.Locuri_taxa)
                .HasForeignKey(d => d.ID_Specializare);

        }
    }
}
