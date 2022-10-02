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
    class SupportTest : BaseTest
    {
        [Test, Description("Create new template - pass")]
        public void TC12_SupportPage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez84levy@gmail.com", "Janjoni#151515");

            // Create new last name
            SupportPage sp = new SupportPage(driver);
            sp.SendSupportMessage("Hi");
            Thread.Sleep(2000);

            // Verify if new last name is correct
            //Assert.That(ap.GetUserLastName(), Is.EqualTo("EREZ Levy"));

            //Logout
            lp.LogOutUser();
        }
    }
}
