using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Keysproject
{
    class Login
    {
        IWebDriver driver;
        public int Details { get; private set; }

        public void LoginTo()
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
        

    }
}
