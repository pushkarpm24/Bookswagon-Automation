using BooksWagon.JsonFile;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace BooksWagon.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
       
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Login')]")]
        public IWebElement LoginButton;
        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtEmail")]
        public IWebElement EmailBox;
        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtPassword")]
        public IWebElement Password;
        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_btnLogin")]
        public IWebElement FinalLoginButton;
        [FindsBy(How = How.Id, Using = "ctl00_imglogo")]
        public IWebElement HomeButton;

        public void AccountLogin()
        {
            Credentials cred = new Credentials();

            LoginButton.Click();
            Thread.Sleep(2000);            
            EmailBox.SendKeys(cred.email);
            Thread.Sleep(2000);
            Password.SendKeys(cred.password);
            Thread.Sleep(2000);
            FinalLoginButton.Click();
            Thread.Sleep(2000);
            HomeButton.Click();
            Thread.Sleep(2000);
        }
    }
}
