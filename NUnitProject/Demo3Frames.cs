using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProject
{
    public class Demo3Frames
    {
        [Test]
        public void HDFCFrameTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));
            
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("john");
            //driver.FindElement(By.XPath("//a[text()='CONTINUE']")).Click();
            driver.FindElement(By.LinkText("CONTINUE")).Click();


            driver.SwitchTo().DefaultContent();




        }
    }
}
