using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonAutomation.Core;
using OpenQA.Selenium;

namespace AmazonAutomation.PageObjects
{
    public class SignInPage : BasePage
    {
        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public RegistrationPage ClickProceedToCreateAccount()
        {
            driver.FindElement(By.Id("intention-submit-button")).FindElement(By.CssSelector(".a-button-input")).Click();
            return new RegistrationPage(driver);
        }

        public void FillEmailOrPhone(string identification)
        {
            driver.FindElement(By.Id("ap_email_login")).SendKeys(identification);
        }

        public SignInPage ClickContinue()
        {
            driver.FindElement(By.CssSelector(".a-button-input")).Click();
            return this;
        }
    }
}
