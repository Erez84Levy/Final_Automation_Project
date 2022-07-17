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
    class EditTest : BaseTest
    {
        [Test, Description("Delete a Project - pass")]
        public void TC05_EditPage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez-l@novami.com", "Ella@151515");

            // Edit The first project
            EditPage ep = new EditPage(driver);
            ep.ChangeProjectName("Erez_Project2");

            Thread.Sleep(3000);

            // Verify if the project name exist or not
            //Assert.That(mp.getProjectName(), Is.EqualTo("Erez_Project"));
        }
    }
}
