using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcept2
{
    public class Demo2FBSignUp
    {
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.LinkText("Sign up for Facebook")).Click();

            driver.FindElement(By.Name("firstname")).SendKeys("john");
            driver.FindElement(By.Name("lastname")).SendKeys("wick");
            driver.FindElement(By.Id("password_step_input")).SendKeys("welcome123");
            
            //xpath example.
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();

            //Dropdown example.
            SelectElement dateDropdown = new SelectElement(driver.FindElement(By.Id("day")));
            dateDropdown.SelectByText("15");

            SelectElement monthDropdown = new SelectElement(driver.FindElement(By.Id("month")));
            monthDropdown.SelectByText("Jun");

            SelectElement yearDropdown = new SelectElement(driver.FindElement(By.Id("year")));
            yearDropdown.SelectByValue("1992");


            //driver.Quit();


        }
    }
}
