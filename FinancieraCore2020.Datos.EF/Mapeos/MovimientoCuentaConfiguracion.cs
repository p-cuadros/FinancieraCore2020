using FinancieraCore2020.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancieraCore2020.Datos.EF.Mapeos
{
    public class MovimientoCuentaConfiguracion : IEntityTypeConfiguration<MovimientoCuenta>
    {
        public void Configure(EntityTypeBuilder<MovimientoCuenta> builder)
        {
            builder.HasKey(c => c.NumeroMovimiento);
            builder.Property(c => c.NumeroMovimiento).HasColumnName("NUM_MOVIMIENTO").IsRequired();
            builder.Property(c => c.IdCuenta).HasColumnName("ID_CUENTA").IsRequired();
            builder.Property(c => c.IdTipoMovimiento).HasColumnName("ID_TIPO").HasMaxLength(10).IsRequired();
            builder.Property(c => c.MontoMovimiento).HasColumnName("MON_MOVIMIENTO").IsRequired();
            builder.HasOne(c => c.Cuenta).WithMany().HasForeignKey(f => f.IdCuenta);
            builder.HasOne(c => c.Tipo).WithMany().HasForeignKey(f => f.IdTipoMovimiento);
        }
    }
}