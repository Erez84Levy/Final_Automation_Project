using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project_Automation.PageObject
{
    class WorkspacesPage : BasePage
    {
        public WorkspacesPage(IWebDriver driver) : base(driver)
        { }
        public IWebElement DeclineAll => findElementByCSS("#cookiescript_buttons #cookiescript_reject");
        public IWebElement DropDownWorkspaceMenu => findElementByCSS(@"#app > div:nth-child(4) > div > div > div.mt-8.md\:mt-0.md\:col-span-8.lg\:col-span-9 > div.p-4.bg-white.shadow.sm\:rounded-lg > div.justify-between.items-center.md\:flex.md\:px-0 > div > div.relative.dropdown.mr-3 > button > svg > path");
        public IWebElement RenameBtn => findElementByCSS(@"#app > div:nth-child(4) > div > div > div.mt-8.md\:mt-0.md\:col-span-8.lg\:col-span-9 > div.p-4.bg-white.shadow.sm\:rounded-lg > div.justify-between.items-center.md\:flex.md\:px-0 > div > div.relative.dropdown.mr-3 > ul > li:nth-child(1) > button");
        public IWebElement RenameWorkspaceName => findElementByCSS("#text-5pqxjq-g2npzj");
        public IWebElement RenameConfirmBtn => findElementByCSS("#confirm-create-button");
        public IWebElement WorkspaceList => findElementByCSS(@"#app > div:nth-child(4) > div > div > div.md\:col-span-4.lg\:col-span-3 > div > div > div.mt-6.space-y-1.overflow-y-auto.max-h-\[25\.7rem\] > a.flex.justify-between.font-medium.px-3.py-2.rounded-md.transition-colors.duration-150.bg-slate-800.text-white.cursor-auto");

        public void CreateNewWorkspace  (string workspaceNewName)
        {
            DeclineAll.Click();
            Thread.Sleep(2000);
            DropDownWorkspaceMenu.Click();
            Thread.Sleep(2000);
            RenameBtn.Click();
            FillText(RenameWorkspaceName, workspaceNewName);
            RenameConfirmBtn.Click();
        }
        //public string GetPopsUpMessage()
        //{
        //    return GetText(Message);
        //}

        public string GetWorkspaceName()
        {

            IList<IWebElement> list =
                Driver.FindElements(By.CssSelector(@"#app > div:nth-child(4) > div > div > div.md\:col-span-4.lg\:col-span-3 > div > div > div.mt-6.space-y-1.overflow-y-auto.max-h-\[25\.7rem\] > a.flex.justify-between.font-medium.px-3.py-2.rounded-md.transition-colors.duration-150.bg-slate-800.text-white.cursor-auto"));
            foreach (var item in list)
            {
                if (item.Equals("GTA"))
                {
                    return GetText(item);
                }
            }
            return null;
        }
        public void ChooseWorkspaceName()
        {

            IList<IWebElement> list =
                Driver.FindElements(By.CssSelector(@"#app > div:nth-child(4) > div > div > div.md\:col-span-4.lg\:col-span-3 > div > div > div.mt-6.space-y-1.overflow-y-auto.max-h-\[25\.7rem\] > a.flex.justify-between.font-medium.px-3.py-2.rounded-md.transition-colors.duration-150.bg-slate-800.text-white.cursor-auto"));
            foreach (var item in list)
            {
                if (item.Equals("GTA"))
                {
                    item.Click();
                }
            }
        }
    }
}
