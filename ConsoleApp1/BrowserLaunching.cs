using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp1
{
    class BrowserLaunching
    {
        protected IWebDriver wdriver = null;
        protected EventFiringWebDriver driver = null;
        //protected TheEventListener eventListerner = null;

        protected WebDriverWait wait = null;
        static void Main(string[] args)
        {
            String driverpath = @"F:/Selenium_Drivers";
            var IEoptions = new InternetExplorerOptions()
            {
                InitialBrowserUrl = "http://www.demoqa.com",
                IntroduceInstabilityByIgnoringProtectedModeSettings =true,
                
            };
            var ChromeOptions = new ChromeOptions()
            {
                
            };
            var FirefoxOptions = new FirefoxOptions()
            {

            };
            IWebDriver wdriver = new InternetExplorerDriver(driverpath, IEoptions);
            IWebDriver cdriver = new ChromeDriver(driverpath);
            IWebDriver fdriver = new FirefoxDriver(driverpath);
            wdriver.Navigate();
        }
    }
}
