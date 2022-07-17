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
    class CouponTest : BaseTest
    {
        [Test, Description("Create new coupon - pass")]
        public void TC06_CouponPage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez-l@novami.com", "Ella@151515");

            // Create New Coupon
            CouponPage cp = new CouponPage(driver);
            cp.CreteNewCoupon("rert");

            Thread.Sleep(3000);

            // Verify if the project name exist or not
            //Assert.That(mp.getProjectName(), Is.EqualTo("Erez_Project"));
        }
        
        [Test, Description("Create new coupon with 2 coupon code - fail")]
        public void TC07_CouponPage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez-l@novami.com", "Ella@151515");

            // Create New Coupon
            CouponPage cp = new CouponPage(driver);
            cp.CreteNewCoupon("rert");

            Thread.Sleep(3000);

            // Verify if the project name exist or not
            //Assert.That(mp.getProjectName(), Is.EqualTo("Erez_Project"));
        }
        
        [Test, Description("Delete coupon - pass")]
        public void TC08_CouponPage()
        {
            // Login
            LoginPage lp = new LoginPage(driver);
            lp.PersonEmail("erez-l@novami.com", "Ella@151515");

            // Delete coupon
            CouponPage cp = new CouponPage(driver);
            cp.DeleteCoupon();

            Thread.Sleep(3000);

            // Verify that there is no coupons
            Assert.That(cp.GetTitlePage(), Is.EqualTo("There is no coupon code list in your account yet."));
        }
    }
}
