using System;
using System.Collections.Generic;
using static System.Configuration.ConfigurationManager;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Utils.Selenium
{
    public class Settings
    {
        //To use app.config file 
        //Type ConfigurationManager.AppSetting[""] and the got to Refrences and right click
        //Add Reference then got to assembly on the left and the search for config check the
        //System.configration and the you can use it
        //Now cut the ConfigurationManager from the line and paste it in the using line with static 
        public static string BaseUrl = AppSettings["BaseUrl"];
    }
}
