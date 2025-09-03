using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonAutomation.Core;
using OpenQA.Selenium;

namespace AmazonAutomation.PageObjects
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) 
        {
            this.driver = driver;
        }
        public SignInPage ClickOnSignIn()
        {
            var signInButton = driver.FindElement(By.Id("nav-link-accountList-nav-line-1"));
            signInButton.Click();
            return new SignInPage(driver);
        }

        public bool IsUserLoggedIn(string userName)
        {
            var helloMessage = driver.FindElement(By.Id("nav-link-accountList-nav-line-1"));
            return helloMessage.Text.Contains(userName);
        }
    }
}
