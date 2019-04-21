using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class SearchSteps
    {
        [StepDefinition(@"user submits the search")]
        public void GivenUserSubmitsTheSearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"opens first product ffrom the list")]
        public void GivenOpensFirstProductFfromTheList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user clicks on add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user proceeds to checkout")]
        public void WhenUserProceedsToCheckout()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"cart page is opened")]
        public void ThenCartPageIsOpened()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"user enters a '(.*)' search term")]
        public void GivenUserEntersASearchTerm(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
       
        [Then(@"results for a '(.*)' search term are displayed")]
        public void ThenResultsForASearchTermAreDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
