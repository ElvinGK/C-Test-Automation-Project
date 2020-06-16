using PageObjectModel.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PageObjectModel.Steps
{
    public sealed class BaseScenarioSteps : BaseSteps
    {
        //Here inorder to reduce instancting many classes here (ex. var c = new class) 
        //we use InstanceOf<>()
        //Because of this feature we dont need to instancte every class here

        #region Definitions
        [Given(@"the user navigates to the homepage")]
        public void GivenTheUserNavigatesToTheHomepage()
        {
            InstanceOf<Basepage>().NavigateMainEnteryPoint();
        }

        #endregion

    }
}
