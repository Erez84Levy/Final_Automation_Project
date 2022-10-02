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
    class PreviewTest : BaseTest
    {
        [Test, Description("Create new template - pass")]
        public void TC09_TemplatePage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez84levy@gmail.com", "Janjoni#151515");

            // Create New Coupon
            PreviewPage pp = new PreviewPage(driver);
            pp.CreteNewTemplate("rert");

            Thread.Sleep(3000);

            // Verify if the project name exist or not
            Assert.That(pp.GetTemplateName(), Is.EqualTo("rert"));
        }
    }
}
