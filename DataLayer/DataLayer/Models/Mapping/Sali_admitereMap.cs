using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class Sali_admitereMap : EntityTypeConfiguration<Sali_admitere>
    {
        public Sali_admitereMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Sala);

            // Properties
            this.Property(t => t.ID_Sala)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nume_Sala)
                .HasMaxLength(50);

            this.Property(t => t.Pavilion)
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("Sali_admitere");
            this.Property(t => t.ID_Sala).HasColumnName("ID_Sala");
            this.Property(t => t.Nume_Sala).HasColumnName("Nume_Sala");
            this.Property(t => t.Pavilion).HasColumnName("Pavilion");
            this.Property(t => t.Etaj).HasColumnName("Etaj");
            this.Property(t => t.Capacitate).HasColumnName("Capacitate");
        }
    }
}
