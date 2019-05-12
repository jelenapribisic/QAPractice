using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationPractice.Steps;

namespace AutomationPractice.Pages
{
    class FooterPage
    {
        readonly IWebDriver driver;

        // public Footer = By.ClassName("footer");
        //public Footer(IWebDriver driver)
        public FooterPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("footer-container")));
        }
        public void ClickOnInformationLink(string title)
        {
            By link = By.CssSelector(".toggle-footer [title='" + title + "']");
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(link)).Click();

        }


        public bool InformationpageElementDisplayed(string page)
        {
            By Informationlink = By.XPath("//*[@class='navigation_page'][contains(text(),'" + page + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Informationlink)).Displayed;
        }
        public void ClickOnMyaccountLink(string title)
        {
            By link = By.CssSelector(".toggle-footer [title='" + title + "']");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(link)).Click();

        }


        public bool MyaccountpageElementDisplayed(string page)
        {
            By Informationlink = By.XPath("//*[@class='navigation_page'][contains(text(),'" + page + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Informationlink)).Displayed;
        }
    }
}
