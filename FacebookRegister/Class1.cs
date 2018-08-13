using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TrademeRegister
{
    class Program
    {
        static IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {

        }
        [SetUp]
        public void Initialize()
        {
            //string FacebookUrl = "https://www.facebook.com/";
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();

        }

        [TestCase]
        public void NameTest()
        {
            IWebElement firstName = driver.FindElement(By.Name("firstname"));
            firstName.SendKeys("Thomas");
            IWebElement lastName = driver.FindElement(By.Name("lastname"));
            lastName.SendKeys("Zhang");
            Thread.Sleep(3000);
        }

        [TestCase]
        public void NumberEmailTest()
        {
            IWebElement numberEmail = driver.FindElement(By.Name("reg_email__"));
            numberEmail.SendKeys("123@yahoo.com");
            Thread.Sleep(3000);
        }

        [TearDown]
        public void Exit()
        {
            driver.Quit();
        }






    }
}
