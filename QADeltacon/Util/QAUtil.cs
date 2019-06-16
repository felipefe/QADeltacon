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

        internal void LoginSistema()
        {
            driverNavegadorChrome.FindElement(By.)
        }

        public void NavegadorAberto()
        {
            Assert.IsTrue(driverNavegadorChrome.ToString().Contains("Chrome"));
        }

    }
}
