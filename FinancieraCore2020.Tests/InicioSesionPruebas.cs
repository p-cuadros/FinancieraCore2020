using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace FinancieraCore2020.Tests
{
    public class InicioSesionPruebas
    {
        IWebDriver driver;

        [SetUp]
        public void Iniciar()
        {
            //driver = new ChromeDriver();
            var options = new ChromeOptions();
            // options.AddArguments("--headless");
            // options.AddArguments("--disable-gpu");
            // options.AddArguments("--disable-dev-shm-usage");
            // options.AddAdditionalCapability(CapabilityType.Version, "latest", true);
            // options.AddAdditionalCapability(CapabilityType.Platform, "WIN10", true);
            // options.AddAdditionalCapability("key", "key", true);
            // options.AddAdditionalCapability("secret", "secret", true);
            // options.AddAdditionalCapability("name", TestContext.CurrentContext.Test.Name, true);            
            // if (driver == null){
                //driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/"), options.ToCapabilities(), TimeSpan.FromSeconds(600));
            var capabilities = options.ToCapabilities();
            var url = "http://localhost:4446/wd/hub";
            driver = new RemoteWebDriver(new Uri(url), options);
            //}
        }

        [Test]
        public void Probar()
        {
            Thread.Sleep(3000);
            //driver.Url = "http://www.google.com.pe";
            driver.Url = "http://oficinavirtual.epstacna.com.pe/src/vista/v_login.php";
            //driver.Navigate().GoToUrl("http://oficinavirtual.epstacna.com.pe/src/vista/v_login.php");
            // driver.Manage().Window.Maximize();
            // Thread.Sleep(3000);
            // driver.FindElement(By.XPath("//*[@id='usu']")).SendKeys("1111");
            // Thread.Sleep(3000);
            // driver.FindElement(By.XPath("//*[@id='pas']")).SendKeys("1111");
            // Thread.Sleep(3000);
            // driver.FindElement(By.XPath("/html/body/div/div[2]/div/form/div[3]/div/button")).Click();
            Thread.Sleep(3000);
        }

        [TearDown]
        public void Terminar()
        {
            driver.Close();            
        }
    }
}