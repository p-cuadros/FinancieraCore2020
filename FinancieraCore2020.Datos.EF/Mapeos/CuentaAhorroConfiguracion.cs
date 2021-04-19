using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FinancieraCore2020.Dominio.Entidades;
namespace FinancieraCore2020.Datos.EF.Mapeos
{
    public class CuentaAhorroConfiguracion : IEntityTypeConfiguration<CuentaAhorro>
    {
        public void Configure(EntityTypeBuilder<CuentaAhorro> builder)
        {
            builder.ToTable("CUENTAS_AHORRO");
            builder.HasKey(c => c.IdCuenta);
            builder.Property(c => c.IdCuenta).HasColumnName("ID_CUENTA").IsRequired();
            builder.Property(c => c.NumeroCuenta).HasColumnName("NUM_CUENTA").HasMaxLength(10).IsRequired();
            builder.Property(c => c.IdPropietario).HasColumnName("ID_CLIENTE").IsRequired();
            builder.HasOne(c => c.Propietario).WithMany().HasForeignKey(f => f.IdPropietario);
        }
    }
}