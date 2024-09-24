using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace NUnitProject
{
    public class SeleniumTasks
    {
        [Test]
        public void DB4FreeTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/phpMyAdmin/";

            driver.FindElement(By.Id("input_username")).SendKeys("Admin");
            driver.FindElement(By.Id("input_password")).SendKeys("Admin123");
            driver.FindElement(By.Id("input_go")).Click();

            string errorMessage = driver.FindElement(By.XPath("(//div[@class='alert alert-danger'])[3]")).Text;
            Console.WriteLine(errorMessage);
        }

        [Test]
        public void OpenMRTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "http://demo.openemr.io/b/openemr/";

            driver.FindElement(By.Id("authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            SelectElement langDropdown = new SelectElement(driver.FindElement(By.XPath("//select[@class='form-control']")));
            langDropdown.SelectByText("English (Indian)");
            
            driver.FindElement(By.Id("login-button")).Click();

            driver.FindElement(By.XPath("//div[text()='Patient']")).Click();
            driver.FindElement(By.XPath("//div[text()='New/Search']")).Click();


            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='pat']")));
            driver.FindElement(By.Id("form_fname")).SendKeys("FirstName");
            driver.FindElement(By.Id("form_lname")).SendKeys("LastName");

            driver.FindElement(By.Id("form_DOB")).SendKeys(DateTime.Now.ToShortDateString());

            SelectElement genderDropdown = new SelectElement(driver.FindElement(By.Id("form_sex")));
            genderDropdown.SelectByValue("Female");

            driver.FindElement(By.Id("create")).Click();

            driver.SwitchTo().DefaultContent();

            driver.SwitchTo().Frame(driver.FindElement(By.Id("modalframe")));
            driver.FindElement(By.XPath("//button[contains(text(),'Confirm Create')]")).Click();
            driver.SwitchTo().DefaultContent();
            
            Thread.Sleep(10000);
            driver.SwitchTo().Alert().Accept();

            //driver.SwitchTo().Frame(driver.FindElement(By.Id("modalframe")));

            string ActualAlertText = driver.FindElement(By.XPath("//div[@class='modal-content ']")).Text;
            Console.WriteLine(ActualAlertText);
            
            



        }


    }
}
