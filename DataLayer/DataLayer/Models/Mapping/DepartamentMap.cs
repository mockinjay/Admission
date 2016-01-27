using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class DepartamentMap : EntityTypeConfiguration<Departament>
    {
        public DepartamentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Departament);

            // Properties
            this.Property(t => t.ID_Departament)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nume_departament)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Departament");
            this.Property(t => t.ID_Departament).HasColumnName("ID_Departament");
            this.Property(t => t.Nume_departament).HasColumnName("Nume_departament");
            this.Property(t => t.ID_Facultate).HasColumnName("ID_Facultate");

            // Relationships
            this.HasOptional(t => t.Facultati)
                .WithMany(t => t.Departaments)
                .HasForeignKey(d => d.ID_Facultate);

        }
    }
}
