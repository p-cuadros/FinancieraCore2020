using System;
using System.Collections.Generic;

namespace FinancieraCore2020.Dominio.Entidades
{
    /// <summary>
    /// Clase de dominio que representa una cuenta de ahorro
    /// </summary>
    public class CuentaAhorro
    {
        /// <summary>
        /// 
        /// </summary>
        public int IdCuenta { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public string NumeroCuenta { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Cliente Propietario { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public int IdPropietario { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Tasa { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Saldo { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FechaApertura { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Estado { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ICollection<MovimientoCuenta> Movimientos { get; private set; }
        
        /// <summary>
        /// Primer constructor
        /// </summary>
        public CuentaAhorro()
        {
            Movimientos = new List<MovimientoCuenta>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_numeroCuenta"></param>
        /// <param name="_propietario"></param>
        /// <param name="_tasa"></param>
        /// <returns></returns>
        public static CuentaAhorro Aperturar(string _numeroCuenta, Cliente _propietario, decimal _tasa)
        {
            return new CuentaAhorro()
            {
                NumeroCuenta = _numeroCuenta,
                Propietario = _propietario,
                IdPropietario = _propietario.IdCliente,
                Tasa = _tasa,
                Saldo = 0
            };
        }

        public const string ERROR_MONTO_MENOR_IGUAL_A_CERO = "El monto no puede ser menor o igual a 0";
        
        
        public void Depositar(decimal monto)
        {
            if (monto <= 0)
                throw new Exception (ERROR_MONTO_MENOR_IGUAL_A_CERO);
            Saldo += monto;
        }
        
        public void Retirar(decimal monto)
        {
            if (monto <= 0)
                throw new Exception (ERROR_MONTO_MENOR_IGUAL_A_CERO);
            Saldo -= monto;
        }
        

    }
}