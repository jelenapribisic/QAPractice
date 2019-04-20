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



        public CreateAccountPage(IWebDriver driver)
             
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("account-creation_form")));
        }
    }
}
