using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksWagon.Pages
{
    class HomePage
    {
        IWebDriver driver;
        
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_txtSearch")]
        public IWebElement SearchBox;
        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_Button1")]
        public IWebElement SearchButton;
        [FindsBy(How = How.XPath, Using = "//div[@id='listSearchResult']//div[1]//div[2]//a[1]//img[1]")]
        public IWebElement BookImg;
        [FindsBy(How = How.XPath, Using = "//a[@class='iframe cboxElement']//input[@class='btn-red']")]
        public IWebElement BookNowButton;
          

        public void SelectAnyBook()
        {
            

            SearchBox.Click();
            Thread.Sleep(2000);
            SearchBox.SendKeys("judgment");
            Thread.Sleep(2000);
            SearchButton.Click();
            Thread.Sleep(2000);
            BookImg.Click();
            Thread.Sleep(2000);
                         
           
        }
    }
}
