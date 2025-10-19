using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrangeHRM_Automation.BaseClass;
using OrangeHRM_Automation.Pages;

namespace OrangeHRM_Automation
{
    public class AdminPageTest : BaseTest
    {
        //Login loginpage;

        [Test,Category("Admin")]
        public void adminSection()
        {
           var loginpage = new Login(driver);
            var homepage = new HomePage(driver);
            var adminpage = new AdminPage(driver);
            loginpage.EnterUsername("Admin");
            loginpage.EnterPassword("admin123");
            loginpage.ClickBtn();
            homepage.clickLeave();
            homepage.clickAdmin();
            adminpage.clickAddBtn();
            adminpage.selectUserRole("ess");
            adminpage.selectStatus("Enabled");
            adminpage.enterEmpname("Radha Gupta");
            adminpage.enterUsername("babai0");
            adminpage.enterPassword("1234567a");
            adminpage.enterConfirmPassword("1234567a");
            adminpage.clickSaveBtn();
        }
    }
}
