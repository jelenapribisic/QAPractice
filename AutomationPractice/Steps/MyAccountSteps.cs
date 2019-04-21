using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class MyAccountSteps:Base 
    {
        Utilities ut = new Utilities(Driver);

        public object HomePage { get; private set; }

        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            Homepage hp = new Homepage(Driver);
            ut.ClickOnElement(hp.signIn);
        }
        
        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.username, TestConstants.Username);
            ut.EnterTextInElement(ap.password, TestConstants.Password);
        }
        
        [StepDefinition(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.singinbtn);

        }

        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            MyAccount ma = new MyAccount(Driver);
            Assert.True(ut.ElementDisplayed(ma.signoutbtn), "User is not logged in");

        }
        [When(@"user opens my wishlist")]
        public void WhenUserOpensMyWishlist()
        {
            MyAccount ma = new MyAccount(Driver);
            ut.ClickOnElement(ma.Wishlist);
            
        }
        [Then(@"user can add new wishlist")]
        public void ThenUserCanAddNewWishlist()
        {
            Wishlistpage ma = new Wishlistpage(Driver);
            Assert.True(ut.ElementDisplayed(ma.NewWishlist), "User cannot add wishlist");
        }
        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFlowForCreatingAnAccount()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            string email = ut.GenerateRandomemail();
            ut.EnterTextInElement(ap.email, email);
            ut.ClickOnElement(ap.createaccount);
        }

        [Given(@"user enters all required personal detail")]
        public void GivenUserEntersAllRequiredPersonalDetail()
        {
            CreateAccountPage cap = new CreateAccountPage(Driver);
            ut.EnterTextInElement(cap.firstname, TestConstants.ADfirstname);
            ut.EnterTextInElement(cap.lastname, TestConstants.ADlastname);
            ut.EnterTextInElement(cap.password, TestConstants.Password);
            ut.EnterTextInElement(cap.adfirstname, TestConstants.ADfirstname);
            ut.EnterTextInElement(cap.adlastname, TestConstants.ADlastname);
            ut.EnterTextInElement(cap.Address1, TestConstants.Address1);
            ut.EnterTextInElement(cap.City, TestConstants.City);
            ut.DropdownSelect(cap.State,TestConstants.State);
            ut.EnterTextInElement(cap.PostCode, TestConstants.PostCode);
            ut.EnterTextInElement(cap.Mobile, TestConstants.Mobile);
            ut.EnterTextInElement(cap.Alias, TestConstants.Alias);
            string Fullname = TestConstants.ADfirstname + " " + TestConstants.ADlastname;
            ScenarioContext.Current.Add(TestConstants.Fullname,Fullname);
        }
        [When(@"submits the sign up form")]
        public void WhenSubmitsTheSignUpForm()
        {
            CreateAccountPage cap  = new CreateAccountPage (Driver);
            ut.ClickOnElement(cap.RegisterBtn);
        }

        [Then(@"user's full name is displayed")]
        public void ThenUserSFullNameIsDisplayed()
        {
            string fullname = ScenarioContext.Current.Get<string>(TestConstants.Fullname);
            Assert.True(ut.TextPresentInElement(fullname).Displayed, "User's full name is not displayed");
        }

        [Given(@"user enters a DRESS search term")]
        public void GivenUserEntersADRESSSearchTerm()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
