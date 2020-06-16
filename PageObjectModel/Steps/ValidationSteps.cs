using PageObjectModel.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PageObjectModel.Steps
{
    public sealed class ValidationSteps : BaseSteps
    {
        [Then(@"the user sees the title contains ""(.*)""")]
        public void ThenTheUserSeesTheTitleContains(string expectedTitle)
        {
            InstanceOf<Basepage>().ValidateTitle(expectedTitle);
        }

        [Then(@"the user sees the url contains ""(.*)""")]
        public void ThenTheUserSeesTheUrlContains(string expectedURl)
        {
            InstanceOf<Basepage>().ValidateURL(expectedURl);
        }

        [Then(@"the user see the ""(.*)"" in the page source")]
        public void ThenTheUserSeeTheInThePageSource(string expectedText)
        {
            InstanceOf<Basepage>().ValidateText(expectedText);
        }

    }
}
