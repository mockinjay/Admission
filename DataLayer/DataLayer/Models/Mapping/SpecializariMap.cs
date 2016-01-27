using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class SpecializariMap : EntityTypeConfiguration<Specializari>
    {
        public SpecializariMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Specializare);

            // Properties
            this.Property(t => t.Nume_specializare)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Specializari");
            this.Property(t => t.ID_Specializare).HasColumnName("ID_Specializare");
            this.Property(t => t.Nume_specializare).HasColumnName("Nume_specializare");
            this.Property(t => t.ID_Departament).HasColumnName("ID_Departament");

            // Relationships
            this.HasOptional(t => t.Departament)
                .WithMany(t => t.Specializaris)
                .HasForeignKey(d => d.ID_Departament);

        }
    }
}
