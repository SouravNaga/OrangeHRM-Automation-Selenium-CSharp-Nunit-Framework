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
    public class LoginFunctionality : BaseTest
    {
        //Login loginpage;

        [Test,Category("Login")]
        public void ValidLogin()
        {
           var loginpage = new Login(driver);
            loginpage.EnterUsername("Admin");
            loginpage.EnterPassword("admin123");
            loginpage.ClickBtn();
        }
    }
}
