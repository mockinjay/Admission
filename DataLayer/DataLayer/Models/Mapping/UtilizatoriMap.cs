using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class UtilizatoriMap : EntityTypeConfiguration<Utilizatori>
    {
        public UtilizatoriMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_User);

            // Properties
            this.Property(t => t.ID_User)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Parola)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Utilizatori");
            this.Property(t => t.ID_User).HasColumnName("ID_User");
            this.Property(t => t.Parola).HasColumnName("Parola");
            this.Property(t => t.ID_Candidat).HasColumnName("ID_Candidat");

            // Relationships
            this.HasOptional(t => t.Candidati)
                .WithMany(t => t.Utilizatoris)
                .HasForeignKey(d => d.ID_Candidat);

        }
    }
}
