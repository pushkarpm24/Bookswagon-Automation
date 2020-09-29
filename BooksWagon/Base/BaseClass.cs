using BooksWagon.EmailSend;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.Threading;

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

        [OneTimeTearDown]
        public void Close()
        {
            Thread.Sleep(2000);
            SendMailClass.SendMail();
            driver.Quit();
        }
    }
}
