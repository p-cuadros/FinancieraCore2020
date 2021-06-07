using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
namespace FinancieraCore2020.Tests.Features
{
    [Binding]

    public sealed class InicioDeSesionPruebas
    {
        private readonly ScenarioContext _scenarioContext;
        private string _usuario { get; set; }
        private string _clave { get; set; }
        IWebDriver driver;
        public InicioDeSesionPruebas(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            var options = new ChromeOptions();
            options.AddArguments("--disable-dev-shm-usage");
            var capabilities = options.ToCapabilities();
            var url = "http://localhost:4444/wd/hub";
            driver = new RemoteWebDriver(new Uri(url), options);
        }

        [Given("el usuario (.*)")]
        public void DadoElUsuario(string usuario)
        {
            driver.Url = "http://oficinavirtual.epstacna.com.pe/src/vista/v_login.php";
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='usu']")).SendKeys("usuario");
            _usuario = usuario;
        }
        [Given("y la clave (.*)")]
        public void DadoLaClave(string usuario)
        {
            _usuario = usuario;
        }

        [When("se hace click")]
        public void CuandoSeHaceClickEnLogin()
        {
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
    }
}