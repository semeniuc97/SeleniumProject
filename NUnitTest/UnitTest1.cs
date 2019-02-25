using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnitTest;
using System.Security.Cryptography;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [OneTimeSetUp]
        public void StartTest() 
        {
            //browser = new ChromeDriver(@"C:\Projects\SeleniumProject\NUnitTest\bin\Debug\netcoreapp2.2");
            //browser.Navigate().GoToUrl("http://blog.testproject.io/");
            Browsers.Init();
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            Browsers.Close();
        }

        [Test]
        public void ClickContactUs()
        {
            SitePages.contactUs.GoTo();
            Assert.IsTrue(SitePages.contactUs.isAt());
            SitePages.contactUs.SendYourName("Asya test");
            SitePages.contactUs.SendYourEmail("TestProject@testproject.com");
            SitePages.contactUs.SendYourSubject("Test");
            SitePages.contactUs.SendYourMessage("Test 123");
            SitePages.contactUs.clickSubmit();
            SitePages.contactUs.ValidateMessage();
        }
    }
}