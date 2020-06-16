using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Utils.Drivers
{
    internal static class ChromeWebDriver
    {
        internal static IWebDriver LoadChromeDriver()
        {
            //To hide command prompt when chrome is called
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            var options = new ChromeOptions();
            //you can find the list of argument in 'http://www.assertselenium.com/java/list-of-chrome-driver-command-line-arguments/'
            options.AddArgument("--disable-extensions");

            var driver = new ChromeDriver(driverService, options);
            return driver;
        }
    }
}
