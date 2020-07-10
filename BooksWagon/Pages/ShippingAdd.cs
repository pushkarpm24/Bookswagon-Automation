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
    public class ShippingAdd
    {
        IWebDriver driver;

        public ShippingAdd(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-red']")]
        public IWebElement ContinueButton;
        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewRecipientName")]
        public IWebElement NameBox;
        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewAddress")]
        public IWebElement AddressBox;
        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ddlNewState")]
        public IWebElement StateButton;
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_cpBody_ddlNewState']/option[23]")]
        public IWebElement StateName;
        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewCity")]
        public IWebElement City;
        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewPincode")]
        public IWebElement PinCode;
        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewMobile")]
        public IWebElement MobileNo;
        [FindsBy(How = How.Id, Using = "ctl00_cpBody_imgSaveNew")]
        public IWebElement SaveButton;


        public void AddressInfo()
        {


            ContinueButton.Click();
            Thread.Sleep(2000);
            NameBox.SendKeys("Pushkar");
            Thread.Sleep(2000);
            AddressBox.SendKeys("Ram Nagar");
            Thread.Sleep(2000);
            StateButton.Click();
            Thread.Sleep(2000);
            StateName.Click();
            Thread.Sleep(2000);
            City.SendKeys("Pune");
            Thread.Sleep(2000);
            PinCode.SendKeys("1234");
            Thread.Sleep(2000);
            MobileNo.SendKeys("7768076656");
            Thread.Sleep(2000);
            SaveButton.Click();
            Thread.Sleep(2000);


        }
    }
}
