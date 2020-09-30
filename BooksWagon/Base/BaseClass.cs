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

        [TearDown]
        public void TearDown()
        {
            var filepath = $"{ TestContext.CurrentContext.TestDirectory}\\{TestContext.CurrentContext.Test.MethodName}.jpg";
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(filepath);
            TestContext.AddTestAttachment(filepath, "Test Screenshots");
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
