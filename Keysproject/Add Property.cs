using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keysproject
{
    class Add_Property
    {
        IWebDriver driver;
        public int Details { get; private set; }

        public void OpenMenuOwners()
        {
            Console.WriteLine("inside menuowners funct");

            IWebElement Ownermanu = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]"));
            Ownermanu.Click(); // click on owners

            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Properties")).Click(); // click on properties
            driver.FindElement(By.XPath("//*[@id='main-content']/div/div[1]/div/div[1]/fieldset/div[2]/div/div/div[2]/a[2]")).Click(); // click on Add property
            Thread.Sleep(3000);
        }

        
        public void PropertyDetails()        
        {
            IWebElement propname = driver.FindElement(By.XPath("//*[@id='property - details']/div[2]/div[1]/div[1]/input"));
            propname.SendKeys("RoseCottage");
            driver.FindElement(By.XPath("//*[@id='property-details']/div[2]/div[2]/div/div[1]")).SendKeys("AffordableHousing"); // Type
            driver.FindElement(By.Id("autocomplete")); // Search address 
            driver.FindElement(By.Id("Number")).SendKeys("38");
            driver.FindElement(By.Id("//*[@id='route']")).SendKeys("17-19"); // Street 
            driver.FindElement(By.Id("Suburb")).SendKeys("Blacktown");
            driver.FindElement(By.Id("City")).SendKeys("Sydney");
            driver.FindElement(By.Id("Postcode")).SendKeys("2148");
            driver.FindElement(By.Id("//*[@id='region']")).SendKeys("NSW");
            driver.FindElement(By.XPath("//*[@id='property-details']/div[3]/div[2]/div[1]/textarea")); // Description
            driver.FindElement(By.XPath("TargetRent")).SendKeys("400");
            driver.FindElement(By.Id("Renttype")).SendKeys("Weekly");
            driver.FindElement(By.Id("Landarea")).SendKeys("600");
            driver.FindElement(By.Id("Floorarea")).SendKeys("400");
            driver.FindElement(By.Id("Bedrooms")).SendKeys("2");
            driver.FindElement(By.Id("Bathrooms")).SendKeys("2");
            driver.FindElement(By.Id("Carparks")).SendKeys("2");
            driver.FindElement(By.Id("Yearbuilt")).SendKeys("1995");
        }

        
        public void FinanceDetails()
        {
            driver.FindElement(By.Id("PurchasePrice")).SendKeys("600000");
            driver.FindElement(By.Id("Mortgage")).SendKeys("2000");
            driver.FindElement(By.Id("HomeValue")).SendKeys("700000");
            driver.FindElement(By.ClassName("HomevalueType")).SendKeys("Current");
            driver.FindElement(By.XPath("//*[@id='financeSection']/div[3]/div/div[1]/div[1]/input")); // Amount
            driver.FindElement(By.Id("Frequency")).SendKeys("Weekly");
            driver.FindElement(By.Id("StartDate")).SendKeys("05/11/2018");
            driver.FindElement(By.Id("EndDate")).SendKeys("06/11/18");
            driver.FindElement(By.Id("Amount")).SendKeys("200");
            driver.FindElement(By.Id("Description")).SendKeys("abcdefghij");
            driver.FindElement(By.Id("Date")).SendKeys("05/11/18");

        }

    }
}
