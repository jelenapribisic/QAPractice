using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class FooterSteps:Base

    {
        FooterPage fp = new Footerpage(Driver);


        [When(@"user clicks on '(.*)' option")]
        public void WhenUserClicksOnOption(string link)
        {
           
            fp.ClickOnInformationLink("link");

        }
        
        [Then(@"correct '(.*)' is displayed")]
        public void ThenCorrectIsDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
