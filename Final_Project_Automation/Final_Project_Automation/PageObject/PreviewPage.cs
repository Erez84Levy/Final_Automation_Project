using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project_Automation.PageObject
{
    class PreviewPage : BasePage
    {
        public PreviewPage(IWebDriver driver) : base(driver)
        { }
        public IWebElement DeclineAll => findElementByCSS("#cookiescript_buttons #cookiescript_reject");
        public IWebElement TemplateBtn => findElementByCSS(@"#app > div.bg-primary-900.px-2.sm\:px-4 > nav > div.w-full.hidden.flex-grow.md\:flex.md\:items-center.md\:w-auto.space-x-2 > div.flex.items-center.md\:flex-grow.text-sm.font-medium.space-x-1\.5 > a:nth-child(2)");
        public IWebElement ClickOnFirstTemplate => findElementByCSS(@"#app > div:nth-child(4) > div > div > div > div.md\:col-span-8.lg\:col-span-8.space-y-6 > div:nth-child(2) > div > div:nth-child(1) > div > div.px-3.py-3.text-sm.truncate.align-middle.text-slate-800");
        public IWebElement ChooseFirstTemplate => findElementByCSS(@"#app > div:nth-child(4) > div > div > div > div.md\:col-span-8.lg\:col-span-8.space-y-6 > div:nth-child(2) > div > div:nth-child(1) > div > div.relative > div > a.block.py-2.text-sm.text-white.bg-teal-700.border.border-teal-700.rounded.shadow.hover\:bg-teal-600.hover\:border-teal-600");
        public IWebElement EditTemplateName => findElementByCSS(".form-group #project-name");        
        public IWebElement StartEditingBtn => findElementByCSS(@"#new-project-form > div.form-group.outcome-selection-wrapper.m-b-0 > div > div:nth-child(2) > label > div > button");        
        public IWebElement SaveAndClose => findElementByCSS(".e-close.nav-link");        
        public IWebElement TemplateName => findElementByCSS(@"#app > div:nth-child(4) > div > div > div.mt-8.md\:mt-0.md\:col-span-8.lg\:col-span-9 > div.grid.gap-x-4.gap-y-4.px-4.mt-6.sm\:px-0.lg\:mt-8.lg\:gap-y-6.lg\:gap-x-6.xs\:grid-cols-2.md\:grid-cols-2.lg\:grid-cols-3 > div:nth-child(1) > div.absolute.right-0.left-0.mt-8.mx-3.z-100.flex-1 > div.mb-3 > h1");        

        public void CreteNewTemplate(string TemplateName)
        {
            DeclineAll.Click();
            TemplateBtn.Click();
            Thread.Sleep(2000);
            ClickOnFirstTemplate.Click();
            ChooseFirstTemplate.Click();
            //Driver.SwitchTo().Alert();
            FillText(EditTemplateName, TemplateName);
            StartEditingBtn.Click();
            SaveAndClose.Click();
        }
        public string GetTemplateName()
        {
            return GetText(TemplateName);
        }
    }
}
