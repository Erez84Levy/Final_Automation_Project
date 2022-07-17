using Allure.Commons;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final_Project_Automation.Test
{
    class BaseTest
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void SetUP()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://app.involve.me/login";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Thread.Sleep(2000);
            driver.Close();
            driver.Quit();
        }
    }
}

