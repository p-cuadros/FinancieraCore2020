using NUnit.Framework;
using TechTalk.SpecFlow;
using FinancieraCore2020.Dominio.Entidades;

namespace FinancieraCore2020.Dominio.Tests.Steps
{
    [Binding]
    public sealed class CuentaAhorroPruebas
    {
        private readonly ScenarioContext _scenarioContext;
        private CuentaAhorro _cuenta { get; set; }
        private decimal _monto { get; set; }
        private decimal _resultado { get; set; }
        private string _error { get; set; }
        private bool _es_error { get; set; } = false;
        
        public CuentaAhorroPruebas(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("la nueva cuenta numero (.*) con tasa (.*)")]
        public void DadoUnaCuenta(string numeroCuenta, decimal tasa)
        {
            try
            {
                var cliente = Cliente.Registrar("Juan Perez");
                _cuenta = CuentaAhorro.Aperturar(numeroCuenta, cliente, tasa);
            }
            catch (System.Exception ex)
            {
                _es_error = true; 
                _error = ex.Message;
            }            
        }

        [When("con saldo S/ (.*)")]
        [When("yo deposito S/ (.*)")]
        public void CuandoYoDeposito(decimal monto)
        {
            try
            {
                _cuenta.Depositar(monto);
                _resultado = _cuenta.Saldo;
            }
            catch (System.Exception ex)
            {
                _es_error = true; 
                _error = ex.Message;
            }
        }

        [When("yo retiro S/ (.*)")]
        public void CuandoYoRetiro(decimal monto)
        {
            try
            {
                _cuenta.Retirar(monto);
                _resultado = _cuenta.Saldo;
            }
            catch (System.Exception ex)
            {
                _es_error = true; 
                _error = ex.Message;
            }
        }

        [Then("el saldo nuevo deberia ser (.*)")]
        public void EntoncesElResultadoDeberiaSer(int resultado)
        {
            Assert.AreEqual(_resultado, resultado);
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