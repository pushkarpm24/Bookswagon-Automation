// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BooksWagon.Base;
using BooksWagon.EmailSend;
using BooksWagon.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace BooksWagon
{
    [TestFixture]
    public class TestClass : BaseClass
    {
        ExtentReports extent = null;
        ExtentTest test = null;

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\HP\source\repos\BooksWagon\BooksWagon\ExtentReport\TestClass.html");
            extent.AttachReporter(htmlReporter);
        }      

        [Test,Order(0)]        
        public void LoginPageTest()
        {

            try
            {
                test = extent.CreateTest("LoginPageTest").Info("Login Test Started.."); //To write Logs In The Report

                LoginPage login = new LoginPage(driver);
                login.AccountLogin();
                test.Log(Status.Info, "Login Successfull..");

                string expectedPageTitle = "Online Bookstore | Buy Books Online | Read Books Online";
                string actualPageTitle = driver.Title;
                Assert.AreEqual(expectedPageTitle, actualPageTitle);
                test.Log(Status.Pass, "Login Test Passed.."); //shows the pass status in report
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                //taking screenshot anfter login
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("C:\\Users\\HP\\source\\repos\\BooksWagon\\BooksWagon\\ScreenShot\\LoginPageTest.png", ScreenshotImageFormat.Png);
                throw;
            }
        }

        [Test,Order(1)]        
        public void HomePageTest()
        {

            try
            {
                test = extent.CreateTest("HomePageTest").Info("Home Page Test Started.."); //To write Logs In The Report

                HomePage home = new HomePage(driver);
                home.SelectAnyBook();
                test.Log(Status.Info, "Book Added To Cart..");

                string expectedPageUrl = "https://www.bookswagon.com/book/landmark-judgments-that-changed-india/9788129135087";
                string actualPageUrl = driver.Url;
                Assert.AreEqual(expectedPageUrl, actualPageUrl);
                test.Log(Status.Pass, "Home Page Test Passed.."); //shows the pass status in report
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                //taking screenshot anfter login
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("C:\\Users\\HP\\source\\repos\\BooksWagon\\BooksWagon\\ScreenShot\\HomePageTest.png", ScreenshotImageFormat.Png);
                throw;
            }

        }

        [Test, Order(2)]
        public void BookCartFrameTest()
        {

            try
            {
                test = extent.CreateTest("BookCartFrameTest").Info("BookCart Frame Test Started.."); //To write Logs In The Report

                BookCartFrame cart = new BookCartFrame(driver);
                cart.CartFrame();
                test.Log(Status.Info, "Frame handled Successfully..");

                string expectedPageUrl = "https://www.bookswagon.com/book/landmark-judgments-that-changed-india/9788129135087";
                string actualPageUrl = driver.Url;
                Assert.AreEqual(expectedPageUrl, actualPageUrl);
                test.Log(Status.Pass, "BookCart Frame Test Passed.."); //shows the pass status in report
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                //taking screenshot anfter login
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("C:\\Users\\HP\\source\\repos\\BooksWagon\\BooksWagon\\ScreenShot\\BookCartFrameTest.png", ScreenshotImageFormat.Png);
                throw;
            }
        }

        [Test,Order(3)]
        public void ShippingAddTest()
        {

            try
            {
                test = extent.CreateTest("ShippingAddTest").Info("ShippingAdd Test Started.."); //To write Logs In The Report

                ShippingAdd ship = new ShippingAdd(driver);
                ship.AddressInfo();
                test.Log(Status.Info, "Filled All The Credientials Successfully..");

                string expectedPageUrl = "https://www.bookswagon.com/viewshoppingcart.aspx";
                string actualPageUrl = driver.Url;
                Assert.AreEqual(expectedPageUrl, actualPageUrl);
                test.Log(Status.Pass, "ShippingAdd Test Passed.."); //shows the pass status in report
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                //taking screenshot anfter login
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("C:\\Users\\HP\\source\\repos\\BooksWagon\\BooksWagon\\ScreenShot\\ShippingAddTest.png", ScreenshotImageFormat.Png);
                throw;
            }
        }

        [Test, Order(4)]
        public void ReviewOrderTest()
        {

            try
            {
                test = extent.CreateTest("ReviewOrderTest").Info("ReviewOrder Test Started.."); //To write Logs In The Report

                ReviewOrder review = new ReviewOrder(driver);
                review.ReviewAndSave();
                test.Log(Status.Info, "Logout Successfull..");

                Assert.IsTrue(driver.FindElement(By.Id("ctl00_phBody_SignIn_btnLogin")).Displayed);
                test.Log(Status.Pass, "ReviewOrder Test Passed.."); //shows the pass status in report
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                //taking screenshot anfter login
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("C:\\Users\\HP\\source\\repos\\BooksWagon\\BooksWagon\\ScreenShot\\ReviewOrderTest.png", ScreenshotImageFormat.Png);
                throw;
            }
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();           
        }
    }
}
