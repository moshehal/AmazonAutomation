using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonAutomation.Core;
using OpenQA.Selenium;

namespace AmazonAutomation.PageObjects
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal VerificationPage ClickVerifyButton()
        {
            driver.FindElement(By.Id("continue")).Click();
            return new VerificationPage(driver);
        }

        internal void FillPassword(string password)
        {
            driver.FindElement(By.Id("ap_password")).SendKeys(password);
        }

        public void FillUsername(string username)
        {
            driver.FindElement(By.Id("ap_customer_name")).SendKeys(username);
        }

        public void FillVerifyPassword(string password)
        {
            driver.FindElement(By.Id("ap_password_check")).SendKeys(password);
        }
    }
}
