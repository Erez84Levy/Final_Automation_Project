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
    class InviteTest : BaseTest
    {
        [Test, Description("Invite new pepole - pass")]
        public void TC13_InvitePage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez-l@novami.com", "Ella@151515");

            // Invaite new pepole
            InvitePage ip = new InvitePage(driver);
            ip.InviteNewPepole("erez84levy@gmail.com");
            Thread.Sleep(2000);

            // Verify that we can't invite pepole
            Assert.That(ip.GetPopsUpMessage(), Is.EqualTo("You've used all your available seats."));
        }
    }
}
