using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept2
{
    public class Demo3SalesForce
    {
        static void Main4(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");
            
            SelectElement jobTitleDropdown = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            jobTitleDropdown.SelectByValue("IT_Manager_AP");

            SelectElement countryDropdown = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            countryDropdown.SelectByText("United Kingdom");

            SelectElement employeesDropdown = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            employeesDropdown.SelectByText("101 - 200 employees");            

            driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[2]")).Click();

            driver.FindElement(By.Name("start my free trial")).Click();

            string actualHeader = driver.FindElement(By.TagName("h1")).Text;
            Console.WriteLine(actualHeader);

            string actualError = driver.FindElement(By.XPath("//span[contains(text(),'valid phone')]")).Text;
            Console.WriteLine(actualError);





        }
    }
}
