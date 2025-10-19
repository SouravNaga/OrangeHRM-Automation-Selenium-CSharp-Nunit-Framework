using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Automation.Pages
{
    public class AdminPage
    {
        public IWebDriver driver;
        public CommonPageMethod common;
        public AdminPage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            common = new CommonPageMethod(driver);
        }
        // Total record count display
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'orangehrm-vertical-padding')]/span")]
        private IWebElement numberOfRecords;

        // Add button
        [FindsBy(How = How.XPath, Using = "//button[text()=' Add ']")]
        private IWebElement addBtn;

        // User Role dropdown
        [FindsBy(How = How.XPath, Using = "(//div[text()='-- Select --'])[1]")]
        private IWebElement userRole;

        // Status dropdown
        [FindsBy(How = How.XPath, Using = "//label[text()='Status']/parent::div/following-sibling::div")]
        private IWebElement status;

        // Employee Name input
        [FindsBy(How = How.XPath, Using = "//label[text()='Employee Name']/parent::div/following-sibling::div/descendant::input")]
        private IWebElement empName;

        // Username input
        [FindsBy(How = How.XPath, Using = "//label[text()='Username']/parent::div/following-sibling::div/descendant::input")]
        private IWebElement username;

        // Password input
        [FindsBy(How = How.XPath, Using = "//label[text()='Password']/parent::div/following-sibling::div/descendant::input")]
        private IWebElement password;

        // Confirm Password input
        [FindsBy(How = How.XPath, Using = "//label[text()='Confirm Password']/parent::div/following-sibling::div/descendant::input")]
        private IWebElement confirmPassword;

        // Save button
        [FindsBy(How = How.XPath, Using = "//button[text()=' Save ']")]
        private IWebElement saveBtn;

        public void clickAddBtn()
        {
            common.WaitForClickable(addBtn);
            common.clickBtn(addBtn);
        }
        public void clickSaveBtn()
        {
            common.WaitForClickable(saveBtn);
            common.clickBtn(saveBtn);
            common.IsElementPresent(addBtn);
            Assert.IsTrue(common.IsElementPresent(addBtn),"Add button is not showing");
            common.IsElementPresent(numberOfRecords);
            Console.WriteLine("Total records found : " + numberOfRecords.Text);
        }
        public void selectUserRole(string role)
        {
            bool flag = false;
            try
            {
                Actions actions = new Actions(driver);
                common.WaitForClickable(userRole);
                common.clickBtn(userRole);
                if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    actions.SendKeys(Keys.ArrowDown).Perform();
                    flag = true;
                }
                else if (role.Equals("ESS", StringComparison.OrdinalIgnoreCase))
                {
                    actions.SendKeys(Keys.ArrowDown)
                           .SendKeys(Keys.ArrowDown)
                           .Perform();
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                    actions.SendKeys(Keys.Enter)
                        .Build()
                        .Perform();
            }
            catch (Exception e) { 
                Console.WriteLine(e.ToString());
                throw;
            }
            finally
            {
                if(flag!=true)
                {
                    Assert.Fail("Option not matching");
                }
            }

        }

        public void selectStatus(string statusvalue)
        {
            
            common.WaitForClickable(status);
            common.clickBtn(status);
            bool flag = false;
            try
            {
                Actions actions = new Actions(driver);
                
                if (statusvalue.Equals("Enabled", StringComparison.OrdinalIgnoreCase))
                {
                    actions.SendKeys(Keys.ArrowDown).Perform();
                    flag = true;
                }
                else if (statusvalue.Equals("Disabled", StringComparison.OrdinalIgnoreCase))
                {
                    actions.SendKeys(Keys.ArrowDown)
                           .SendKeys(Keys.ArrowDown)
                           .Perform();
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                actions.SendKeys(Keys.Enter)
                    .Build()
                    .Perform();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
            finally
            {
                if (flag != true)
                {
                    Assert.Fail("Option not matching");
                }
            }

        }
        public void enterEmpname(string emp)
        {
            Actions actions = new Actions(driver);
            common.WaitForVisible(empName);
            common.enterText(empName,emp);
            Thread.Sleep(2000);
            actions.SendKeys(Keys.ArrowDown)
                .SendKeys(Keys.Enter)
                .Build()
                .Perform();


        }
        public void enterUsername(string user)
        {
            common.WaitForVisible(username);
            common.enterText(username, user);
        }
        public void enterPassword(string pass)
        {
            common.WaitForVisible(password);
            common.enterText(password, pass);
        }
        public void enterConfirmPassword(string pass)
        {
            common.WaitForVisible(confirmPassword);
            common.enterText(confirmPassword, pass);
        }
    }
}
