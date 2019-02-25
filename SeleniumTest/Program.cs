using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (IWebDriver browser = new ChromeDriver())
            {
                browser.Manage().Window.Maximize();
                browser.Navigate().GoToUrl("https://app.pluralsight.com/id?redirectTo=%2Fid%2Fdashboard");

                IWebElement loginInput = browser.FindElement(By.Id("Username"));
                loginInput.SendKeys("semeniuc97@gmail.com");

                IWebElement passwordInput = browser.FindElement(By.Id("Password"));
                passwordInput.SendKeys("!234qwer" + Keys.Enter);

                Console.ReadLine();
            }


        }
    }
}
