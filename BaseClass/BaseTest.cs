using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OrangeHRM_Automation.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            Console.WriteLine("Test");
        }

        [TearDown]
        public void closeBrowser()
        {
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}