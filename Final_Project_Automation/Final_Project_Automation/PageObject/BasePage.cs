using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project_Automation.PageObject
{
    class BasePage
    {

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
            WaitDriver = new WebDriverWait(driver, new TimeSpan(0, 0, 50));
        }

        protected IWebDriver Driver { get; private set; }

        protected WebDriverWait WaitDriver { get; private set; }

        protected IWebElement findElementByCSS(string cssOrName, bool isByName = false)
        {
            ; return WaitDriver.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(isByName ? By.Name(cssOrName) : By.CssSelector(cssOrName)));
        } 

        public void FillText(IWebElement el, string text)
        {
            // IJavaScriptExecutor jse = (IJavaScriptExecutor)(Driver);
            // jse.ExecuteScript("arguments[0].value='" + text + "';", el);

            el.Click();     // Must click before clearing input element
            el.Clear();
            el.SendKeys(text);
        }

        public void Click(IWebElement el) {
            el.Click();
        }

        public void Submit(IWebElement el) { 
            el.Submit();
        }

        public string GetText(IWebElement el)
        {
            return el.Text;
        }

    }

}

