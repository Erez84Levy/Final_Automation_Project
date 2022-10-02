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
    class AccountTest : BaseTest
    {
        [Test, Description("Create new template - pass")]
        public void TC10_AccountPage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez84levy@gmail.com", "Janjoni#151515");

            // Create new last name
            AccountPage ap = new AccountPage(driver);
            ap.CreteNewLastName("Levy");
            Thread.Sleep(2000);

            // Verify if new last name is correct
            Assert.That(ap.GetUserLastName(), Is.EqualTo("EREZ Levy"));

            //Logout
            lp.LogOutUser();
        }

        [Test, Description("Verify that last name is not correct - pass")]
        public void TC11_AccountPage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez84levy@gmail.com", "Janjoni#151515");

            // Verify that the last name isn't correct
            AccountPage ap = new AccountPage(driver);
            Assert.That(ap.GetUserLastName(), Is.EqualTo("Levy"));
        }
    }
}
