using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FinancieraCore2020.Dominio.Entidades;
namespace FinancieraCore2020.Datos.EF.Mapeos
{
    public class ClienteConfiguracion : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.IdCliente);
            builder.ToTable("CLIENTES").HasComment("Tabla de Clientes");
            builder.Property(c => c.IdCliente).HasColumnName("ID_CLIENTE").HasComment("Identificador unico del cliente");
            builder.Property(c => c.NombreCliente).HasColumnName("NOM_CLIENTE").HasComment("Nombre del cliente").HasMaxLength(200).IsRequired();
        }
    }
}