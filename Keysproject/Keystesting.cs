using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keysproject
{
    [TestFixture]
    public class Keystesting
    {
        IWebDriver driver;

        
        [SetUp]
        public void StartBrowserandLogin() 
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://new-keys.azurewebsites.net/Account/Login";                                                
            driver.FindElement(By.Id("UserName")).SendKeys("vincent.nguyen@mvpstudio.co.nz");
            driver.FindElement(By.Id("Password")).SendKeys("ntmv2682");
            driver.FindElement(By.XPath("//*[@id='sign_in']/div[1]/div[4]/button")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("a.introjs-button.introjs-skipbutton")).Click(); // click on skip button 
            Thread.Sleep(4000);
        }

        [Test]
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

            //IWebElement propname = driver.FindElement(By.XPath("//*[@id='property - details']/div[2]/div[1]/div[1]/input"));
            //propname.SendKeys("RoseCottage");   
            driver.FindElement(By.Name("propertyName")).SendKeys("RoseCottage");
            //driver.FindElement(By.XPath("//*[@id='property-details']/div[2]/div[2]/div/div[1]")).SendKeys("AffordableHousing"); // Type
            driver.FindElement(By.Name("searchAddress")).SendKeys("671");
            Thread.Sleep(3000);
            driver.FindElement(By.Name("searchAddress")).SendKeys(Keys.ArrowDown + Keys.Enter);
            // driver.FindElement(By.Id("Number")).SendKeys("38");
            // driver.FindElement(By.Id("//*[@id='route']")).SendKeys("17-19"); Street 
            // driver.FindElement(By.Id("Suburb")).SendKeys("Blacktown");
            // driver.FindElement(By.Id("City")).SendKeys("Sydney");
            // driver.FindElement(By.Id("Postcode")).SendKeys("2148");
            //  driver.FindElement(By.Id("//*[@id='region']")).SendKeys("NSW");
            driver.FindElement(By.ClassName("add-prop-desc")).SendKeys("abcdefghij");
            driver.FindElement(By.XPath("//*[@id='property-details']/div[4]/div/div[1]/div[1]/input")).SendKeys("400");
            //Rent.SendKeys("400");
          // driver.FindElement(By.Id("Renttype")).SendKeys("Weekly");
          // driver.FindElement(By.Id("Landarea")).SendKeys("600");
          // driver.FindElement(By.Id("Floorarea")).SendKeys("400");
             driver.FindElement(By.XPath("//*[@id='property-details']/div[6]/div[1]/div[1]/input")).SendKeys("2");
            //Bedrooms.Sendkeys("2");
             driver.FindElement(By.XPath("//*[@id='property-details']/div[6]/div[2]/div[1]/input")).SendKeys("2");
            //Bathrooms.Sendkeys("2");
             driver.FindElement(By.XPath("//*[@id='property-details']/div[7]/div[1]/div[1]/input")).SendKeys("2");
            //Carparks.SendKeys("2");
             driver.FindElement(By.XPath("//*[@id='property-details']/div[7]/div[2]/div[1]/input")).SendKeys("1900");
            //Yearbuilt.SendKeys("1995");
             driver.FindElement(By.Id("file-upload")).SendKeys("C:/Users/home/Pictures/KeysProperty.jpg");
             driver.FindElement(By.Name("next")).Click();

        }

        
        public void FinanceDetails()
        {
            driver.FindElement(By.Name("purchasePrice")).SendKeys("600000");
            driver.FindElement(By.Name("mortgagePrice")).SendKeys("2000");
            driver.FindElement(By.XPath("//*[@id='financeSection']/div[1]/div[3]/div[1]/input")).SendKeys("700000"); // Homevalue
          //driver.FindElement(By.ClassName("HomevalueType")).SendKeys("Current"); 
            driver.FindElement(By.XPath("//*[@id='financeSection']/div[4]/div/span")).Click(); //Repayments
            driver.FindElement(By.XPath("//*[@id='financeSection']/div[3]/div/div[1]/div[1]/input")).SendKeys("2000"); //Amount
          //driver.FindElement(By.Id("Frequency")).SendKeys("Weekly");
            driver.FindElement(By.Id("payment-start-date")).SendKeys("26/11/2018");
          //driver.FindElement(By.Id("EndDate")).SendKeys("27/11/2018");
            driver.FindElement(By.XPath("//*[@id='financeSection']/div[7]/div/span")).Click(); //Expense
            IList<IWebElement> Amount_Description = driver.FindElements(By.Id("Text1"));
            Amount_Description[0].SendKeys("200");
            Amount_Description[1].SendKeys("abcdefghijk");
         // driver.FindElement(By.Id("expense-date")).SendKeys("27/11/2018"); 


        }//class
        

    }


}


    







