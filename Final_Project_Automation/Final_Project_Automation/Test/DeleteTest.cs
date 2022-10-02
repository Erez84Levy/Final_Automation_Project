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
    class DeleteTest : BaseTest
    {
        [Test, Description("Delete a Project - pass")]
        public void TC04_DeletePage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez84levy@gmail.com", "Janjoni#151515");

            // Delete The first project
            DeletePage dp = new DeletePage(driver);
            dp.DeleteSpecificProject();

            Thread.Sleep(3000);

            // Verify if the project name exist or not
            //Assert.That(mp.getProjectName(), Is.EqualTo("Erez_Project"));
        }
    }
}
