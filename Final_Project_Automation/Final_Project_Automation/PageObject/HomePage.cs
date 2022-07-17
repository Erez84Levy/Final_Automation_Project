using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Automation.PageObject
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement UserName => findElementByCSS(".text-sm.font-medium.truncate");
        public IWebElement WrongCer => findElementByCSS(".alert.alert-danger");

        public string getUserName()
        {
            return GetText(UserName);
        }
        public string getWrongCredentials()
        {
            return GetText(WrongCer);
        }
    }
}
