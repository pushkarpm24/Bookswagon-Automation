// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using BooksWagon.Base;
using BooksWagon.Pages;
using NUnit.Framework;

namespace BooksWagon
{
    [TestFixture]
    public class TestClass : BaseClass
    {

        [Test,Order(0)]        
        public void LoginPageTest()
        {
            LoginPage login = new LoginPage(driver);
            login.AccountLogin();
        }

        [Test,Order(1)]        
        public void HomePageTest()
        {
            HomePage home = new HomePage(driver);
            home.SelectAnyBook();
           // YourAccount a = new YourAccount(driver);
        }

        [Test, Order(2)]
        public void BookCartFrameTest()
        {
            BookCartFrame cart = new BookCartFrame(driver);
            cart.CartFrame();
        }

        [Test,Order(3)]
        public void ShippingAddTest()
        {
            ShippingAdd ship = new ShippingAdd(driver);
            ship.AddressInfo();
        }

        [Test, Order(4)]
        public void ReviewOrderTest()
        {
            ReviewOrder review = new ReviewOrder(driver);
            review.ReviewAndSave();
        }
    }
}
