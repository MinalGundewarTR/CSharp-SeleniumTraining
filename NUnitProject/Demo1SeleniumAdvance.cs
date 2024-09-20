using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProject
{
    public class Demo1SeleniumAdvance
    {
        [Test]
        public void Demo1MultipleTabsTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin »
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            //Switch to 2nd tab.
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            driver.FindElement(By.Id("input_password")).SendKeys("admin123");
            driver.FindElement(By.Id("input_go")).Click();

            driver.Close();

            driver.SwitchTo().Window(driver.WindowHandles[0]);
            string windowtitle = driver.Title.ToString();
            Console.WriteLine(windowtitle); 

           
        }

        [Test]
        public void Demo2TabsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://online.citibank.co.in/";

            //Parent child hierarchy.
            //driver.FindElement(By.XPath("//div[@class='popup-1']/a")).Click();
            //driver.FindElement(By.XPath("//div[@class='popup-2']/a")).Click();
            driver.FindElement(By.ClassName("newclose")).Click();
            driver.FindElement(By.ClassName("newclose2")).Click();


            driver.FindElement(By.Id("topMnubanking")).Click();
            
            //Parent child hierarchy.
            //driver.FindElement(By.XPath("//li[@class='last']/ul")).Click();
            driver.FindElement(By.PartialLinkText("Citi Commercial Bank")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//a[@title='Branch/ATM']")).Click();

            driver.FindElement(By.XPath("//a[text()='Choose One']")).Click();
            driver.FindElement(By.LinkText("Bengaluru")).Click();

            driver.Close();




        }

    }
}
