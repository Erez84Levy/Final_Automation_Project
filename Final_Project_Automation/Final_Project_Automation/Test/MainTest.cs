using Final_Project_Automation.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project_Automation.Test
{
    class MainTest : BaseTest
    {
        [Test, Description("Create New Project - pass")]
        public void TC03_MainPage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez-l@novami.com", "Ella@151515");

            // Create new project
            MainPage mp = new MainPage(driver);
            mp.createNewProject("Erez_Project");

            Thread.Sleep(2000);

            // Verify if the project name exist or not
            Assert.That(mp.findProjectByName("Erez_Project"), Is.EqualTo("Erez_Project"));
        }
    }
}
