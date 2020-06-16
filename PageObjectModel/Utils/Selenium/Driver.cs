using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PageObjectModel.Utils.Selenium
{
    //Binding is needed to hook it to specflow
    [Binding]
    internal class Driver
    {
        internal static IWebDriver Browser() => DriverController.Instance.WebDriver;
    }
}
