  
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FinancieraCore2020.Dominio.Entidades;

namespace FinancieraCore2020.Datos.EF.Mapeos
{
    public class TipoMovimientoConfiguracion : IEntityTypeConfiguration<TipoMovimiento>
    {
        public void Configure(EntityTypeBuilder<TipoMovimiento> builder)
        {
            builder.ToTable("TIPOS_MOVIMIENTO");
            builder.HasKey(c => c.IdTipo);
            builder.Property(c => c.IdTipo).HasColumnName("ID_TIPO").ValueGeneratedOnAdd();
            builder.Property(c => c.DescripcionTipo).HasColumnName("DES_TIPO").HasMaxLength(100).IsRequired();
        }
    }
}