using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace LolaFlora.UITestProject.Models.LolaFlora
{
    public class BasePage
    {
        IWebDriver driver;
        WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        public IWebElement FindElement(By by)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
            return driver.FindElement(by);
        }

        public void NavigateUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickElement(By by)
        {
            FindElement(by).Click();
        }

        public void SendKeys(By by, String value)
        {
            FindElement(by).SendKeys(value);
        }

        public bool IsElementVisible(By by)
        {
            return FindElement(by).Displayed && FindElement(by).Enabled;
        }

        public string GetAttribute(By by, string value)
        {
            return FindElement(by).GetAttribute(value);
        }

        public string GetText(By by)
        {
            return FindElement(by).Text;
        }

        public void DragAndDropToOffset(By by)
        {
            Actions move = new Actions(driver);
            move.DragAndDropToOffset(FindElement(by), 30, 0).Perform();
        }

        public void WaitFromSeconds(int second)
        {
            Thread.Sleep(TimeSpan.FromSeconds(second));
        }
    }
}
