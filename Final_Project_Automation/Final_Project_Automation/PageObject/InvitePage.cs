using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project_Automation.PageObject
{
    class InvitePage : BasePage
    {
        public InvitePage(IWebDriver driver) : base(driver)
        { }
        public IWebElement DeclineAll => findElementByCSS("#cookiescript_buttons #cookiescript_reject");
        public IWebElement UserShortBtn => findElementByCSS(@"#app > div:nth-child(4) > div > div > div.mt-8.md\:mt-0.md\:col-span-8.lg\:col-span-9 > div.p-4.bg-white.shadow.sm\:rounded-lg > div.justify-between.items-center.md\:flex.md\:px-0 > div.flex.flex-grow.items-center.h-10.md\:mb-0 > div.flex.px-4.md\:px-0 > span:nth-child(1)");
        public IWebElement EnterAnEmail => findElementByCSS("[name=user-email]");
        public IWebElement InviteBtn => findElementByCSS(@"#app > div:nth-child(6) > div > div > div > form > div > div:nth-child(2) > div > button");
        public IWebElement Message => findElementByCSS(@"#app > div:nth-child(6) > div > div > div > form > div > div:nth-child(2) > span");

        public void InviteNewPepole(string Mail)
        {
            DeclineAll.Click();
            UserShortBtn.Click();
            Thread.Sleep(4000);
            //Driver.SwitchTo().Alert();
            FillText(EnterAnEmail, Mail);
            InviteBtn.Click();
        }
        public string GetPopsUpMessage()
        {
            return GetText(Message);
        }
    }
}
