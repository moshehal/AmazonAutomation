using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonAutomation.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonAutomation.Core
{
    public class BasePage
    {
        protected IWebDriver driver;

        public IWebDriver InitializeDriver()
        {
            var options = new ChromeOptions();
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }

        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }

        public MainPage NavigateTo(string expectedURL)
        {
            driver.Navigate().GoToUrl(expectedURL);
            return new MainPage(driver);
        }

        public string GetVerificationCode()
        {
            //Need to add get the code from email.
            return "";
        }
    }
}
