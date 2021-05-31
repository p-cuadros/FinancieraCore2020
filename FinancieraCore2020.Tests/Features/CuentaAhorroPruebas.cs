using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using FinancieraCore2020.Dominio.Entidades;

namespace FinancieraCore2020.Tests.Steps
{
    [Binding]
    public sealed class CuentaAhorroPruebas
    {
        private readonly ScenarioContext _scenarioContext;
        private CuentaAhorro _cuenta { get; set; }
        private string _error { get; set; }
        private bool _es_error { get; set; } = false;
        
        public CuentaAhorroPruebas(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("la nueva cuenta numero (.*)")]
        public void DadoUnaNuevaCuenta(string numeroCuenta)
        {
            try
            {
                var cliente = Cliente.Registrar("Juan Perez");
                _cuenta = CuentaAhorro.Aperturar(numeroCuenta, cliente, 1);
            }
            catch (System.Exception ex)
            {
                _es_error = true; 
                _error = ex.Message;
            }            
        }

        // [Given("con saldo (.*)")]
        // public void YConSaldo(decimal monto)
        // {
        //     CuandoYoDeposito(monto);
        // }

        [Given("con saldo (.*)")]
        [When("deposito (.*)")]
        public void CuandoYoDeposito(decimal monto)
        {
            try
            {
                _cuenta.Depositar(monto);
            }
            catch (System.Exception ex)
            {
                _es_error = true; 
                _error = ex.Message;
            }
        }

        [When("retiro (.*)")]
        public void CuandoYoRetiro(decimal monto)
        {
            try
            {
                _cuenta.Retirar(monto);
                //_resultado = _cuenta.Saldo;
            }
            catch (System.Exception ex)
            {
                _es_error = true; 
                _error = ex.Message;
            }
        }

        [Then("el saldo nuevo deberia ser (.*)")]
        public void EntoncesElResultadoDeberiaSer(decimal resultado)
        {
            Assert.AreEqual(_cuenta.Saldo, resultado);
        }        

        [Then("deberia ser error")]
        public void EntoncesDeberiaMostrarseError()
        {
            Assert.IsTrue(_es_error);
        }

        [Then("deberia mostrarse el error: (.*)")]
        public void EntoncesDeberiaMostrarseError(string error)
        {
            Assert.AreEqual(_error, error);
        }
    }
}