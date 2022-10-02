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
    class WorkspacesTest : BaseTest
    {
        [Test, Description("Create new workspaces - pass")]
        public void TC14_WorkspacesPage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez84levy@gmail.com", "Janjoni#151515");

            // Create new workspace
            WorkspacesPage wp = new WorkspacesPage(driver);
            wp.CreateNewWorkspace("GTA");
            Thread.Sleep(2000);

            // Verify that we have the correct workspace
            Assert.That(wp.GetWorkspaceName(), Is.EqualTo("GTA"));
        }
        
        [Test, Description("Rename workspaces name - pass")]
        public void TC15_WorkspacesPage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez84levy@gmail.com", "Janjoni#151515");

            // Rename the workspace name
            WorkspacesPage wp = new WorkspacesPage(driver);
            wp.ChooseWorkspaceName();
            Thread.Sleep(2000);
            wp.CreateNewWorkspace("GTA3");

            // Verify that we have the correct workspace
            Assert.That(wp.GetWorkspaceName(), Is.EqualTo("GTA"));
        }
    }
}
