using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;

namespace NUnitTest.Pages
{
    public class ContactUs
    {
        [FindsBy(How = How.Name, Using = "your-name")]
        private IWebElement yourName;
        [FindsBy(How = How.Name, Using = "your-email")]
        private IWebElement yourEmail;
        [FindsBy(How = How.Name, Using = "your-subject")]
        private IWebElement yourSubject;
        [FindsBy(How = How.Name, Using = "your-message")]
        private IWebElement yourMessage;
        [FindsBy(How = How.ClassName, Using = "wpcf7-form-control")]
        private IWebElement submit;
        [FindsBy(How = How.ClassName, Using = "wpcf7-response-output")]
        private IWebElement SuccMessage;
        [FindsBy(How = How.Id, Using = "menu-item-1296")]
        private IWebElement contactUs;
        public bool isAt()
        {
            return Browsers.Title.Contains("Contact Us");
        }
        public void GoTo()
        {
            contactUs.Click();
        }
        public void SendYourName(string name)
        {
            yourName.SendKeys(name);
        }
        public void SendYourEmail(string email)
        {
            yourEmail.SendKeys(email);
        }
        public void SendYourSubject(string Subject)
        {
            yourSubject.SendKeys(Subject);
        }
        public void SendYourMessage(string massage)
        {
            yourMessage.SendKeys(massage);
        }
        public void clickSubmit()
        {
            submit.Click();
        }
        public void ValidateMessage()
        {
            try
            {
                var text = SuccMessage.Text;
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
    }
}
