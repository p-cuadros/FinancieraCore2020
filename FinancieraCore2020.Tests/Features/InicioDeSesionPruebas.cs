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
        public void DadoLaClave(string clave)
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='pas']")).SendKeys("clave");
            _clave = clave;
        }

        [When("se hace click en iniciar sesion")]
        public void CuandoSeHaceClickEnLogin()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[2]/div/form/div[3]/div/button")).Click();
        }

        [Then("el usuario permanece en la misma pagina")]
        public void EntoncesElUsuarioPermaneceEnLaMismaPagina()
        {
            Thread.Sleep(3000);
            var boton = driver.FindElement(By.XPath("/html/body/div/div[2]/div/form/div[3]/div/button")).Text;
            //driver.FindElement(By.XPath("//*[@id='pas']")).SendKeys("clave");
            Assert.IsNotNull(boton);
        }        
    }
}