using NUnitTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NUnitTest
{
    public class Browsers
    {
        private static IWebDriver webDriver;
        public static ReportsManager reports; // adding the report vaiable
        private static string baseURL = @"https://blog.testproject.io/";
        private static string browser = "Chrome";
        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver(@"C:\Projects\SeleniumProject\NUnitTest\bin\Debug\netcoreapp2.2");
                    break;
                case "IE":
                    webDriver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
            }
            webDriver.Manage().Window.Maximize();
            reports = new ReportsManager(browser, baseURL);  // Creating New Instance of report
            Goto(baseURL);
        }
        public static string Title
        {
            get { return webDriver.Title; }
        }
        public static IWebDriver getDriver
        {
            get { return webDriver; }
        }
        public static void Goto(string url)
        {
            webDriver.Url = url;
            reports.verifyURL(url); // Verifying the URL
        }
        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
