using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class BeneficiariMap : EntityTypeConfiguration<Beneficiari>
    {
        public BeneficiariMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Beneficiar);

            // Properties
            this.Property(t => t.Nume_beneficiar)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Beneficiari");
            this.Property(t => t.ID_Beneficiar).HasColumnName("ID_Beneficiar");
            this.Property(t => t.Nume_beneficiar).HasColumnName("Nume_beneficiar");
        }
    }
}
