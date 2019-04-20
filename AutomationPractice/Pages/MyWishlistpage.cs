using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class Wishlistpage
    {
        readonly IWebDriver driver;
        public By NewWishlist = By.Id ("form_wishlist");
        public Wishlistpage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("module-blockwishlist-mywishlist")));
        }
    }
}
