using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProject
{
    public class Demo2Alert
    {
        [Test]
        public void AlertTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();
            //driver.FindElement(By.XPath("//img[contains(@src,'go.gif')]").Click();

            string ActualAlertText = driver.SwitchTo().Alert().Text;
            Console.WriteLine(ActualAlertText);
            Thread.Sleep(2000);

            driver.SwitchTo().Alert().Accept();

        }
    }
}
