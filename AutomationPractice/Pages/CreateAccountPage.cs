using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class CreateAccountPage
    {
        readonly IWebDriver driver;
        public By firstname = By.Id("customer_firstname");
        public By lastname = By.Id("customer_lastname");
        //public By email = By.Id("email");//
        public By password = By.Id("passwd");
        public By adfirstname = By.Id("firstname");
        public By adlastname = By.Id("lastname");
        public By Address1 = By.Id("address1");
        public By City = By.Id("city");
        public By State = By.Id("id_state");
        public By PostCode = By.Id("postcode");
        
        public By Mobile = By.Id("phone_mobile");
        public By Alias = By.Id("alias");
        public By RegisterBtn = By.Id("submitAccount");






        public CreateAccountPage(IWebDriver driver)
             
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("account-creation_form")));
        }
    }
}
