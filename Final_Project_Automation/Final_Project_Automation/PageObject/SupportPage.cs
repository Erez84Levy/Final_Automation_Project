using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project_Automation.PageObject
{
    class SupportPage : BasePage
    {
        public SupportPage(IWebDriver driver) : base(driver)
        { }
        public IWebElement DeclineAll => findElementByCSS("#cookiescript_buttons #cookiescript_reject");
        public IWebElement UserDropDownMenu => findElementByCSS("#nav-dropdown > svg");
        public IWebElement SupportBtn => findElementByCSS(@"#app > div.bg-primary-900.px-2.sm\:px-4 > nav > div.w-full.hidden.flex-grow.md\:flex.md\:items-center.md\:w-auto.space-x-2 > div.flex.text-sm.items-center.space-x-2 > div > ul > li:nth-child(7) > a");
        public IWebElement StartChatBtn => findElementByCSS(@"#app > div:nth-child(4) > div > div > div:nth-child(2) > div > div.grid.grid-cols-1.md\:grid-cols-2.gap-6 > div:nth-child(2) > div.grow-0.flex.items-end.justify-between > button.px-6.py-2.leading-5.rounded.bg-teal-800.text-white.hover\:bg-teal-700.hover\:shadow.focus\:outline-none.focus\:ring.cursor-pointer");
        public IWebElement OpenChatBtn => findElementByCSS(@"#app > div:nth-child(6) > div > div > div > div > div.bg-gray-100.px-6.py-3.flex > div > button");        
        public IWebElement SendAMessageBtn => findElementByCSS(".intercom-18biwo.e1prtmiu1");        
        public IWebElement MessageTab => findElementByCSS("[name=message]");        
        public IWebElement SendBtn => findElementByCSS(@"#intercom-container > div > div > div.intercom-messenger.intercom-messenger-new-conversation.intercom-messenger-from-home-screen.intercom-pyuhix.e1gli0d30 > div.intercom-1xafcqx.ens34ad0 > div > div.intercom-6ve7wk.e6876yz0 > div > div.intercom-composer-buttons.intercom-hloib6.e50zdj11 > button.intercom-composer-send-button.intercom-18z1pbu.e50zdj18 > svg > path");        

        public void SendSupportMessage(string Message)
        {
            DeclineAll.Click();
            UserDropDownMenu.Click();
            SupportBtn.Click();
            StartChatBtn.Click();
            OpenChatBtn.Click();
            Thread.Sleep(4000);
            //Driver.SwitchTo().Alert();
            SendAMessageBtn.Click();
            FillText(MessageTab, Message);
            SendBtn.Click();
        }
    }
}
