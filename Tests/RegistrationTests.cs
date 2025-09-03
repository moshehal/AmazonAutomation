using AmazonAutomation.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonAutomation.Tests
{
    public class Tests : BasePage
    {
        [SetUp]
        public void Setup()
        {
            InitializeDriver();
        }

        [Test]
        public void AddNewUserHappyFlow()
        {
            #region TestParams
            string email = "moshenav6365+5@gmail.com";
            string password = "123456";
            string username = "Moshe";
            #endregion

            var mainPage = NavigateTo("https://www.amazon.com/");
            var signInPage = mainPage.ClickOnSignIn();
            signInPage.FillEmailOrPhone(email);
            signInPage.ClickContinue();
            var registrationPage = signInPage.ClickProceedToCreateAccount();
            registrationPage.FillUsername(username);
            registrationPage.FillPassword(password);
            registrationPage.FillVerifyPassword(password);
            var verificationPage = registrationPage.ClickVerifyButton();
            string verificationCode = GetVerificationCode();
            verificationPage.FillVerificationCode(verificationCode);
            var marketPage = verificationPage.ClickContinue();
            Assert.That(marketPage.IsUserLoggedIn(username), "The user logged in to the system");
        }

        [Test]
        public void AddNewAccountHappyFlow()
        {
            NavigateTo("https://www.amazon.com/");
        }

        [TearDown]
        public void TearDown()
        {
            CloseDriver();
        }
    }
}