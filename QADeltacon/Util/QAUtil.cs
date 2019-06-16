using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Util
{
    [TestClass]
    public class QAUtil
    {
        IWebDriver driverNavegadorChrome;

        [TestMethod]
        public void IniciarNavegador()
        {

            driverNavegadorChrome = new ChromeDriver(@"C:\Users\CoreBusiness\source\repos\QADeltacon\QADeltacon\chromeDrive\");
            driverNavegadorChrome.Navigate().GoToUrl("http://localhost/COREBusiness");
            driverNavegadorChrome.Manage().Window.Maximize();

        }

        internal void CliqueEntrarSistema()
        {
            driverNavegadorChrome.FindElement(By.Id("UserName")).SendKeys("DeltaconUser");
            driverNavegadorChrome.FindElement(By.Id("Password")).SendKeys("Delt@12345");
            driverNavegadorChrome.FindElement(By.ClassName("btn waves-effect waves-light green darken-2")).Click();
        }

        internal void Entrou()
        {
            driverNavegadorChrome.Manage().Window.Minimize();
        }

        public void NavegadorAberto()
        {
            Assert.IsTrue(driverNavegadorChrome.ToString().Contains("Chrome"));
        }

    }
}
