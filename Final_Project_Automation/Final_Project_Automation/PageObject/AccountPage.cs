using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project_Automation.PageObject
{
    class AccountPage : BasePage
    {
        public AccountPage(IWebDriver driver) : base(driver)
        { }
        public IWebElement DeclineAll => findElementByCSS("#cookiescript_buttons #cookiescript_reject");
        public IWebElement UserDropDownMenu => findElementByCSS("#nav-dropdown > svg");
        public IWebElement AccountSettingsBtn => findElementByCSS(@"#app > div.bg-primary-900.px-2.sm\:px-4 > nav > div.w-full.hidden.flex-grow.md\:flex.md\:items-center.md\:w-auto.space-x-2 > div.flex.text-sm.items-center.space-x-2 > div > ul > li:nth-child(1) > a");
        public IWebElement LastNameTab => findElementByCSS("[name = profile-lastname]");
        public IWebElement UpdateProgileBtn => findElementByCSS(@"#account-profile > div.p-4.md\:py-4.md\:px-16.bg-slate-100.last\:rounded-b-lg > button");        
        public IWebElement ProjectBtn => findElementByCSS(@"#app > div.bg-primary-900.px-2.sm\:px-4 > nav > div.w-full.hidden.flex-grow.md\:flex.md\:items-center.md\:w-auto.space-x-2 > div.flex.items-center.md\:flex-grow.text-sm.font-medium.space-x-1\.5 > a:nth-child(1)");        
        public IWebElement UserName => findElementByCSS(@"#nav-dropdown > div > div.text-left.truncate.hidden.lg\:block > div.text-sm.font-medium.truncate");        

        public void CreteNewLastName(string LastName)
        {
            DeclineAll.Click();
            UserDropDownMenu.Click();
            AccountSettingsBtn.Click();
            FillText(LastNameTab, LastName);
            UpdateProgileBtn.Click();
            Thread.Sleep(4000);
            ProjectBtn.Click();
        }
        public string GetUserLastName()
        {
            return GetText(UserName);
        }
    }
}
