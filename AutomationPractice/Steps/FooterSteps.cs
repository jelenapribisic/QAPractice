using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class FooterSteps : Base

    {
        FooterPage fp = new FooterPage(Driver);


        [When(@"user clicks on '(.*)' option")]
        public void WhenUserClicksOnOption(string link)
        {

            fp.ClickOnInformationLink(link);

        }

        [Then(@"correct '(.*)' is displayed")]
        public void ThenCorrectIsDisplayed(string page)
        {
            Assert.True(fp.InformationpageElementDisplayed(page), "Correct Page is not displayed");


        }
        [When(@"user clicks on '(.*)' option under Myaccount section")]
        public void WhenUserClicksOnOptionUnderMyaccountSection(string link)
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"correct '(.*)' under Myaccount is displayed")]
        public void ThenCorrectUnderMyaccountIsDisplayed(string page)
        {
            Assert.True(fp.InformationpageElementDisplayed(page), "Correct Page is displayed");
        }

    }
}
