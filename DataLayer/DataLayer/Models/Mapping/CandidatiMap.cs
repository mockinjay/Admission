using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class CandidatiMap : EntityTypeConfiguration<Candidati>
    {
        public CandidatiMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Candidat);

            // Properties
            this.Property(t => t.Nume)
                .HasMaxLength(50);

            this.Property(t => t.Prenume)
                .HasMaxLength(50);

            this.Property(t => t.Sex)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Adresa)
                .HasMaxLength(100);

            this.Property(t => t.Oras)
                .HasMaxLength(50);

            this.Property(t => t.Judet)
                .HasMaxLength(50);

            this.Property(t => t.Tara)
                .HasMaxLength(50);

            this.Property(t => t.Nationalitate)
                .HasMaxLength(50);

            this.Property(t => t.Religie)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Candidati");
            this.Property(t => t.ID_Candidat).HasColumnName("ID_Candidat");
            this.Property(t => t.Nume).HasColumnName("Nume");
            this.Property(t => t.Prenume).HasColumnName("Prenume");
            this.Property(t => t.CNP).HasColumnName("CNP");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Adresa).HasColumnName("Adresa");
            this.Property(t => t.Oras).HasColumnName("Oras");
            this.Property(t => t.Judet).HasColumnName("Judet");
            this.Property(t => t.Nr_telefon).HasColumnName("Nr_telefon");
            this.Property(t => t.Tara).HasColumnName("Tara");
            this.Property(t => t.Nationalitate).HasColumnName("Nationalitate");
            this.Property(t => t.Religie).HasColumnName("Religie");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Nota_BAC).HasColumnName("Nota_BAC");
        }
    }
}
