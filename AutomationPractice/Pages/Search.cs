using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class Search
    {
        readonly IWebDriver driver;

        public By searchbox = By.Id("searchbox");
        public const string Term = "dress";
        public By submitsearch = By.ClassName("search_query_top");


    }
}
