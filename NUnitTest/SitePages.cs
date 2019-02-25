using NUnitTest.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace NUnitTest
{
    public static class SitePages
    {
        private static T getPages<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browsers.getDriver, page);
            return page;
        }
        public static ContactUs contactUs
        {
            get { return getPages<ContactUs>(); }
        }
    }
}
