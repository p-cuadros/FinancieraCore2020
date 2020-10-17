using FinancieraCore2020.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;

namespace FinancieraCore2020.Datos.EF
{
    /// <summary>
    /// Clase que contiene las entidades y configuraciones de persistencia
    /// del contexto Financiera
    /// </summary>
    public class FinancieraContexto : DbContext 
    {
        // public FinancieraContexto (DbContextOptions<FinancieraContexto> options) : base (options) 
        // { 
        // }
        /// <summary>
        /// Realiza la configuración hacia la base de datos
        /// </summary>
        /// <param name="optionsBuilder">Opciones de configuracion</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseMySql(
            //     "Server=localhost;Database=financiera;User=root;Password=upt.2020;"
            //      , db => db.ServerVersion(
            //          new ServerVersion(new Version(10, 4, 6), ServerType.MariaDb))
            //     );
            optionsBuilder.UseMySql(
                "Server=localhost;Database=financiera;User=root;Password=upt.2020;"
                 , db => db.ServerVersion(
                     new ServerVersion("10.4.11-mariadb"))
                );
        }
        /// <summary>
        /// Conjunto de datos cliente
        /// </summary>
        public DbSet<Cliente> Clientes { get; set; }
        /// <summary>
        /// Conjunto de datos TiposMovimiento
        /// </summary>
        public DbSet<TipoMovimiento> TiposMovimiento { get; set; }
        /// <summary>
        /// Conjunto de datos Cuentas de Ahorro
        /// </summary>
        /// <value></value>
        public DbSet<CuentaAhorro> CuentasAhorro { get; set; }
        /// <summary>
        /// Conjunto de Datos de Movimientos de Cuentas
        /// </summary>
        public DbSet<MovimientoCuenta> MovimientosCuenta { get; set; }
        /// <summary>
        /// Configuración de cada entidad hacia la base de datos
        /// </summary>
        /// <param name="modelBuilder">Constructor del modelo</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entidad =>
            {
                entidad.HasKey(k => k.IdCliente);
            });
            modelBuilder.Entity<TipoMovimiento>(entidad =>
            {
                entidad.HasKey(k => k.IdTipo);
            });
            modelBuilder.Entity<CuentaAhorro>(entidad =>
            {
                entidad.HasKey(k => k.IdCuenta);
            });
            modelBuilder.Entity<MovimientoCuenta>(entidad =>
            {
                entidad.HasKey(k => k.NumeroMovimiento);
            });
        }
           
    }
}