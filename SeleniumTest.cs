using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject
{
    [TestClass]
    public class SeleniumTest
    {
        [TestMethod]
        public void AbrirGoogleTest()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless"); // Importante: GitHub no tiene pantalla real
            
            using (var driver = new ChromeDriver(options))
            {
                driver.Navigate().GoToUrl("https://www.google.com");
                Assert.IsTrue(driver.Title.Contains("Google"));
            }
        }
    }
}
