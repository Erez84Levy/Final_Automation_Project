using Final_Project_Automation.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project_Automation.PageObject
{
    class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement NewProject => findElementByCSS(@"#app > div:nth-child(4) > div > div > div.mt-8.md\:mt-0.md\:col-span-8.lg\:col-span-9 > div.p-4.bg-white.shadow.sm\:rounded-lg > div.justify-between.items-center.md\:flex.md\:px-0 > div.relative.dropdown.mr-3 > button");
        public IWebElement StartFromScrach => findElementByCSS(@"#app > div:nth-child(4) > div > div > div.mt-8.md\:mt-0.md\:col-span-8.lg\:col-span-9 > div.p-4.bg-white.shadow.sm\:rounded-lg > div.justify-between.items-center.md\:flex.md\:px-0 > div.relative.dropdown.mr-3 > ul > li:nth-child(1) > a > p.text-base.font-normal.group-hover\:text-white");
        public IWebElement EnterProjectName => findElementByCSS("project_name", true);
        public IWebElement StartDoing => findElementByCSS(@"#new-project-form > div.form-group.outcome-selection-wrapper.m-b-0 > div > div:nth-child(1) > label > div > button");
        public IWebElement SaveAndExit => findElementByCSS(@".e-close.nav-link");


        public void createNewProject(string projectName)
        {
            NewProject.Click();
            StartFromScrach.Click();
            EnterProjectName.Click();
            EnterProjectName.Clear();
            FillText(EnterProjectName, projectName);
            StartDoing.Click();
            SaveAndExit.Click();
        }

        public string findProjectByName(string projectName)
        {
            string xPathProjectSearch = string.Format("//div[@class='mb-3']/h1/a[text()='{0}']", projectName);

            IWebElement projectElement = Driver.FindElement(By.XPath(xPathProjectSearch));
            return projectElement.Text;
        }
    }
}
