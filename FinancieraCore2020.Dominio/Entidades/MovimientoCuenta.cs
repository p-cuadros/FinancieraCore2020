using System;

namespace FinancieraCore2020.Dominio.Entidades
{
    /// <summary>
    /// Clase de dominio
    /// </summary>
    public class MovimientoCuenta
    {
        /// <summary>
        /// 
        /// </summary>
        public int NumeroMovimiento { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public CuentaAhorro Cuenta { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public int IdCuenta { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public TipoMovimiento Tipo { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public int IdTipoMovimiento { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FechaMovimiento { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal MontoMovimiento { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Estado { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_cuenta"></param>
        /// <param name="_tipo"></param>
        /// <param name="_monto"></param>
        /// <returns></returns>
        public static MovimientoCuenta Crear(CuentaAhorro _cuenta, TipoMovimiento _tipo, decimal _monto)
        {
            return new MovimientoCuenta() {
                Cuenta = _cuenta,
                IdCuenta = _cuenta.IdCuenta,
                Tipo = _tipo,
                IdTipoMovimiento = _tipo.IdTipo,
                FechaMovimiento = DateTime.Now,
                MontoMovimiento = _monto,
                Estado = true
            };
        }
        /// <summary>
        /// 
        /// </summary>
        public void Anular()
        {
            Estado = false;
        }

    }
}