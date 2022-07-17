using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project_Automation.PageObject
{
    class CouponPage : BasePage
    {
        public CouponPage(IWebDriver driver) : base(driver)
        { }
        public IWebElement DeclineAll => findElementByCSS("#cookiescript_buttons #cookiescript_reject");
        public IWebElement CouponBtn => findElementByCSS(@"#app > div.bg-primary-900.px-2.sm\:px-4 > nav > div.w-full.hidden.flex-grow.md\:flex.md\:items-center.md\:w-auto.space-x-2 > div.flex.items-center.md\:flex-grow.text-sm.font-medium.space-x-1\.5 > a:nth-child(5)");
        public IWebElement CreateNewListBtn => findElementByCSS(@"#app > div:nth-child(4) > div > div > div.rounded-lg.shadow.bg-white > div > div > div > div.flex.px-4.md\:px-6 > button > svg");
        public IWebElement InsertInternalName => findElementByCSS("#coupon-list-name-l65bch");        
        public IWebElement DrillDown => findElementByCSS(@".relative.dropdown .fill-current");        
        public IWebElement DeleteCouponBtn => findElementByCSS(@"#app > div:nth-child(4) > div > div > div.rounded-lg.shadow.bg-white > div > div > div > div.rounded-t-lg > table > tbody > tr > td:nth-child(4) > div > ul > li:nth-child(3) > div > button");        
        public IWebElement DeleteCouponBtnAccept => findElementByCSS("#confirm-delete-button");        
        public IWebElement TitleLable => findElementByCSS(@"#app > div:nth-child(4) > div > div > div.rounded-lg.shadow.bg-white > div > div > div > div.rounded-t-lg > p");        

        public void CreteNewCoupon(string CouponName)
        {
            DeclineAll.Click();
            CouponBtn.Click();
            CreateNewListBtn.Click();
            Driver.SwitchTo().Alert();
            FillText(InsertInternalName, CouponName);
        }
        public void DeleteCoupon()
        {
            DeclineAll.Click();
            CouponBtn.Click();
            DrillDown.Click();
            DeleteCouponBtn.Click();
            DeleteCouponBtnAccept.Click();
        }
        public string GetTitlePage()
        {
            return GetText(TitleLable);
        }
    }
}
