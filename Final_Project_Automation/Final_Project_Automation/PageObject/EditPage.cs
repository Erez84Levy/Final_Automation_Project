using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project_Automation.PageObject
{
    class EditPage : BasePage
    {
        public EditPage(IWebDriver driver) : base(driver)
        { }
        public IWebElement ChooseProject => findElementByCSS(@"#app > div:nth-child(4) > div > div > div.mt-8.md\:mt-0.md\:col-span-8.lg\:col-span-9 > div.grid.gap-x-4.gap-y-4.px-4.mt-6.sm\:px-0.lg\:mt-8.lg\:gap-y-6.lg\:gap-x-6.xs\:grid-cols-2.md\:grid-cols-2.lg\:grid-cols-3 > div:nth-child(1) > div.absolute.right-0.left-0.mt-8.mx-3.z-100.flex-1 > div.flex.items-center.justify-between.mb-2 > div.flex.justify-right.items-center > div > button > svg");
        public IWebElement EditProject => findElementByCSS(@"#app > div:nth-child(4) > div > div > div.mt-8.md\:mt-0.md\:col-span-8.lg\:col-span-9 > div.grid.gap-x-4.gap-y-4.px-4.mt-6.sm\:px-0.lg\:mt-8.lg\:gap-y-6.lg\:gap-x-6.xs\:grid-cols-2.md\:grid-cols-2.lg\:grid-cols-3 > div:nth-child(1) > div.absolute.right-0.left-0.mt-8.mx-3.z-100.flex-1 > div.flex.items-center.justify-between.mb-2 > div.flex.justify-right.items-center > div > ul > li:nth-child(1) > a");
        public IWebElement ClickOnProjectName => findElementByCSS("#bs-example-navbar-collapse-1 > ul:nth-child(1) > li");
        public IWebElement EditProjectTitle => findElementByCSS("#icons");
        public IWebElement ChangeProjectTitle => findElementByCSS("[name = project-name]");     
        public IWebElement UpdateSettings => findElementByCSS(@"#general-settings > div.rounded-lg.shadow.bg-white > div.p-4.md\:py-4.md\:px-16.bg-slate-100.last\:rounded-b-lg > button");


        public void ChangeProjectName(string projectTitleName)
        {
            ChooseProject.Click();
            EditProject.Click();
            ClickOnProjectName.Click();
            EditProjectTitle.Click();
            FillText(ChangeProjectTitle, projectTitleName);
            UpdateSettings.Click();
            //Thread.Sleep(4000);

        }
    }
}
