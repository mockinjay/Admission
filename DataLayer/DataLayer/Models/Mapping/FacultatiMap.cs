using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class FacultatiMap : EntityTypeConfiguration<Facultati>
    {
        public FacultatiMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Facultate);

            // Properties
            this.Property(t => t.ID_Facultate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nume_facultate)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Facultati");
            this.Property(t => t.ID_Facultate).HasColumnName("ID_Facultate");
            this.Property(t => t.Nume_facultate).HasColumnName("Nume_facultate");
        }
    }
}
