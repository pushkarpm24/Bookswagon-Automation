using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksWagon.Base
{
    public class BaseClass
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Initlize()
        {
            ChromeOptions opt = new ChromeOptions();
            opt.AddArguments("--disable-notification");

            driver = new ChromeDriver(opt);

           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            string booksWagonUrl = ConfigurationManager.AppSettings["url"];
            driver.Url = booksWagonUrl;
        }

        

    }
}
