using FinancieraCore2020.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FinancieraCore2020.Datos.EF
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Cliente>().HasData(
            //     Cliente.Registrar("Juan Perez"),
            //     Cliente.Registrar("Jose Diaz"),
            //     Cliente.Registrar("Martin Delgado")
            // );
            modelBuilder.Entity<TipoMovimiento>().HasData(
                Cliente.Registrar("Retiro"),
                Cliente.Registrar("Deposito")
            );            
        }
    }
 
}