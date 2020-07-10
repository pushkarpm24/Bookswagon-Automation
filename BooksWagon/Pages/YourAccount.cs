using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWagon.Pages
{
    public class YourAccount
    {

        public YourAccount(IWebDriver driver)
        {             
            PageFactory.InitElements(driver, this);
            driver.Url = "https://www.bookswagon.com/checkout-login";
        }
    }
}
