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
    public class ReviewOrder
    {

        IWebDriver driver;

        public ReviewOrder(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ShoppingCart_lvCart_savecontinue")]
        public IWebElement SaveAndContinue;
        [FindsBy(How = How.Id, Using = "ctl00_lnkbtnLogout")]
        public IWebElement Logout;
        


        public void ReviewAndSave()
        {


            SaveAndContinue.Click();
            Thread.Sleep(2000);
            Logout.Click();
            Thread.Sleep(2000);
            
        }        
    }   
}
