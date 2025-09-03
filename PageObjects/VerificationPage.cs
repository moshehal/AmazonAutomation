using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonAutomation.Core;
using OpenQA.Selenium;

namespace AmazonAutomation.PageObjects
{
    internal class VerificationPage : BasePage
    {
        public VerificationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public MainPage ClickContinue()
        {
            driver.FindElement(By.Id("cvf-submit-otp-button")).FindElement(By.CssSelector(".a-button-input")).Click();
            return new MainPage(driver);
        }

        public void FillVerificationCode(string verificationCode)
        {
            driver.FindElement(By.Id("cvf-input-code")).SendKeys(verificationCode);
        }
    }
}
