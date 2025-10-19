using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Automation.Pages
{
    public class HomePage
    {
        public IWebDriver driver;
        public CommonPageMethod common;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            common = new CommonPageMethod(driver);

        }
        // Admin menu link
        [FindsBy(How = How.XPath, Using = "//span[text()='Admin']")]
        private IWebElement adminLink;

        // Leave menu link
        [FindsBy(How = How.XPath, Using = "//span[text()='Leave']")]
        private IWebElement leaveLink;
        public void clickAdmin()
        {
            common.WaitForClickable(adminLink);
            common.clickBtn(adminLink);
        }
        public void clickLeave()
        {
            common.WaitForClickable(leaveLink);
            common.clickBtn(leaveLink);
        }
    }
}
