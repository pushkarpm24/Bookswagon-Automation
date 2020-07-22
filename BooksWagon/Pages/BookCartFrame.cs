using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksWagon.Pages
{
    public class BookCartFrame
    {
        IWebDriver driver;

        public BookCartFrame(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.Id, Using = "BookCart_lvCart_imgPayment")]
        public IWebElement PlaceOrderButton;

        public void CartFrame()
        {
            IWebElement frame = driver.FindElement(By.CssSelector("body.padtpfix:nth-child(2) div:nth-child(1) div:nth-child(2) div:nth-child(2) div:nth-child(1) > iframe.cboxIframe"));
            driver.SwitchTo().Frame(frame);
            PlaceOrderButton.Click();
             
        }

    }
}
