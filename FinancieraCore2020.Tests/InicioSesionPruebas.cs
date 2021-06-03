using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace FinancieraCore2020.Tests
{
    public class InicioSesionPruebas
    {
        IWebDriver driver;

        [SetUp]
        public void Iniciar()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Probar()
        {
            Thread.Sleep(5000);
            //driver.Url = "http://www.google.com.pe";
            driver.Url = "http://oficinavirtual.epstacna.com.pe/src/vista/v_login.php";
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='usu']")).SendKeys("");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='pas']")).SendKeys("");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[2]/div/form/div[3]/div/button")).Click();
            Thread.Sleep(3000);
        }

        [TearDown]
        public void Terminar()
        {
            driver.Close();            
        }
    }
}