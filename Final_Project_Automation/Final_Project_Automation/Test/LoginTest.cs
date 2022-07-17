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
    class LoginTest : BaseTest
    {
        [Test, Description("Create first login - pass")]
        public void TC01_LoginPage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez-l@novami.com", "Ella@151515");

            //Login Verification passed
            HomePage hp = new HomePage(driver);
            Assert.That(hp.getUserName(), Is.EqualTo("EREZ"));

            //Logout
            lp.LogOutUser();
        }

        [Test, Description("Create first login - failed")]
        public void TC02_LoginPage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez-l@novami.com", "Ella@15151");

            //Login Verification failed            
            HomePage hp = new HomePage(driver);
            Assert.That(hp.getWrongCredentials(), Is.EqualTo("These credentials do not match our records."));
        }
    }
}
