using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class Locuri_bugetMap : EntityTypeConfiguration<Locuri_buget>
    {
        public Locuri_bugetMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Locuri_buget");
            this.Property(t => t.ID_Specializare).HasColumnName("ID_Specializare");
            this.Property(t => t.ID_Beneficiar).HasColumnName("ID_Beneficiar");
            this.Property(t => t.Nr_locuri).HasColumnName("Nr_locuri");
            this.Property(t => t.Din_care_fete).HasColumnName("Din_care_fete");
            this.Property(t => t.ID).HasColumnName("ID");

            // Relationships
            this.HasOptional(t => t.Beneficiari)
                .WithMany(t => t.Locuri_buget)
                .HasForeignKey(d => d.ID_Beneficiar);
            this.HasOptional(t => t.Specializari)
                .WithMany(t => t.Locuri_buget)
                .HasForeignKey(d => d.ID_Specializare);

        }
    }
}
