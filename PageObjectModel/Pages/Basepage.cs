using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static PageObjectModel.Utils.Selenium.Driver;

namespace PageObjectModel.Pages
{
    public class Basepage : Page
    {
        public IWebDriver Driver { get; internal set; }
        public string GetTitle => Driver.Title;
        public string GetURL => Driver.Url;
        public string GetPageSource => Driver.PageSource;


        public void NavigateMainEnteryPoint()
        {
            const string url = "https://en.wikipedia.org/wiki/Main_Page";
            Browser().Navigate().GoToUrl(url);
            Browser().Manage().Window.Maximize();
        }        
        public void ValidateTitle(String expectedTitle)
        {
            var TitleOfPage = GetTitle.Contains(expectedTitle);
            Assert.IsTrue(TitleOfPage, ":: This is not the expected title");
            Console.WriteLine(":: Title of the page is "+ GetTitle);
        }
        public void ValidateURL(String expectedURL)
        {
            var URLOfPage = GetURL.Contains(expectedURL);
            Assert.IsTrue(URLOfPage, ":: This is not the expected title");
            Console.WriteLine(":: URL of the page is " + GetURL);
        }
        public void ValidateText(String expectedText)
        {
            var TextOfPage = GetPageSource.Contains(expectedText);            
            Assert.IsTrue(TextOfPage, ":: This is not the expected title");
            Console.WriteLine(":: Text is in page source " + expectedText);
        }
        public void ValidateMultipleTexts(Table table)
        {
            foreach (var row in table.Rows)
            {
                var TextToValidate = row["expectedText"];
                Assert.IsTrue(GetPageSource.Contains(TextToValidate), ":: This is not the expected title");
                Console.WriteLine(":: Text is in page source " + TextToValidate);

            }
        }

    }
}
