using PageObjectModel.Utils.Selenium;
using TechTalk.SpecFlow;

namespace PageObjectModel.Pages
{
    [Binding]
    public abstract class Page
    {
        protected T InstanceOf<T>() where T : Basepage, new()
        {
            var pageClass = new T { Driver = Driver.Browser()};
            return pageClass;
        }
    }   
}
