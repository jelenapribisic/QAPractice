﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Helpers
{
    public class Utilities
    {
        readonly IWebDriver driver;
        private static readonly Random RandomName = new Random();
        public Utilities(IWebDriver driver)
        {
            this.driver = driver;   
        }
        public void ClickOnElement(By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(selector)).Click();
        }

        public void EnterTextInElement(By selector, string text)
        {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector)).SendKeys(text);
        }
        public bool ElementDisplayed(By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector)).Displayed;
        }
        public string GenerateRandomemail()
        {
            return string.Format("email{0}@malinator.com", RandomName.Next(10000, 100000));
        }

    }
}