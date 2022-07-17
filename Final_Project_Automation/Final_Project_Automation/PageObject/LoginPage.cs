using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project_Automation.PageObject
{
    class LoginPage : BasePage
    {
        public LoginPage (IWebDriver driver) : base(driver)
        {
        }
        public IWebElement Email => findElementByCSS("email", true);
        public IWebElement Password => findElementByCSS("password", true); 
        public IWebElement LoginBtn => findElementByCSS(".btn.btn-primary.btn-lg");
        public IWebElement LogOut => findElementByCSS(@"#app > div.bg-primary-900.px-2.sm/:px-4 > nav > div.w-full.hidden.flex-grow.md/:flex.md\:items-center.md/w-auto.space-x-2 > div.flex.text-sm.items-center.space-x-2 > div > ul > li:nth-child(13) > a");
        
        public void PersonEmail(string mail,string password)
        {
            FillText(Email, mail);
            FillText(Password, password);
            Submit(LoginBtn);
        }
        public void LogOutUser()
        {

            IWebElement dropMenuButton = findElementByCSS("button#nav-dropdown");
            WaitDriver.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(dropMenuButton)).Click();

            IList <IWebElement> list = 
                Driver.FindElements(By.CssSelector(@"#app > div.bg-primary-900.px-2.sm\:px-4 > nav > div.w-full.hidden.flex-grow.md\:flex.md\:items-center.md\:w-auto.space-x-2 > div.flex.text-sm.items-center.space-x-2 > div > ul > li > a"));

            list.Where(item => "Log Out".Equals(item.GetAttribute("innerText"))).Select(

                logOutItem => WaitDriver.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(logOutItem)))

            .First().Click();
        }
    }
}