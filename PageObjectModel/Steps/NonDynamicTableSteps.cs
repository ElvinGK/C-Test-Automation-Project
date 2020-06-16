using PageObjectModel.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PageObjectModel.Steps
{
    public sealed class NonDynamicTableSteps : BaseSteps
    {
        [Then(@"the user see")]
        public void ThenTheUserSee(Table table)
        {
            InstanceOf<Basepage>().ValidateMultipleTexts(table);
        }
    }
}
