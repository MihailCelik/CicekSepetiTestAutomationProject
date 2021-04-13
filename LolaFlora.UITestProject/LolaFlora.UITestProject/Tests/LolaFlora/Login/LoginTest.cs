using LolaFlora.UITestProject.Models.LolaFlora.Login;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace LolaFlora.UITestProject.Tests.LolaFlora.Login
{
    [Binding]
    public sealed class LoginTest
    {
        private LoginModel loginModel;
        private IWebDriver driver { get; set; }

        [BeforeScenario]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("disable-popup-blocking");
            options.AddArgument("disable-notifications");
            options.AddArgument("test-type");
            driver = new ChromeDriver(options);
            loginModel = new LoginModel(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        [StepDefinition("'(.*)' sitesine gidilir")]
        public void OpenLoginPage(string url)
        {
            loginModel.OpenLoginPage(url);
        }

        [StepDefinition("Sign In sayfasının açıldığı görülür")]
        public void CheckIfHeadSignIn()
        {
            Assert.IsTrue(loginModel.CheckIfHeadSignIn(), "Sign In sayfası açılmadı");            
        }

        [StepDefinition("E-Mail alanına '(.*)' yazılır")]
        public void SetTextEmail(string email)
        {
            loginModel.SetTextEmail(email);
        }

        [StepDefinition("Password alanına '(.*)' yazılır")]
        public void SetTextPassword(string password)
        {
            loginModel.SetTextPassword(password);
        }

        [StepDefinition("Sign In butonuna tıklanılır")]
        public void ClickSignIn()
        {
            loginModel.ClickSignIn();
        }

        [StepDefinition("LolaFlora ana sayfasına giriş yapıldığı görülür")]
        public void CheckIfLoginIsMyAccountVisible()
        {
            Assert.IsTrue(loginModel.CheckIfLoginIsMyAccountVisible(), "Giriş Yapılamadı");
        }

        [StepDefinition("'(.*)' pop-up geldiği görülür")]
        public void CheckIfAlertMessage(string popupText)
        {
            Assert.IsTrue(loginModel.CheckIfAlertMessage().Contains(popupText), "Uyarı mesajı doğru gelmedi");
        }

        [StepDefinition("Pop-up üzerindek Ok butonuna tıklanılır")]
        public void ClickOk()
        {
            loginModel.ClickOk();
        }

        [StepDefinition("Email alanında '(.*)' uyarı mesajının geldiği görülür")]
        public void ControlEmptyEmailAlertMessage(string emptyEmailAlertMessage)
        {
            Assert.IsTrue(loginModel.ControlEmptyEmailAlertMessage().Contains(emptyEmailAlertMessage), "E-mail uyarı mesajı eşleşmedi");
        }

        [StepDefinition("Password alanında '(.*)' uyarı mesajının geldiği görülür")]
        public void ControlEmptyPasswordAlertMessage(string emptyPasswordAlertMessage)
        {
            Assert.IsTrue(loginModel.ControlEmptyPasswordAlertMessage().Contains(emptyPasswordAlertMessage), "Password uyarı mesajı eşleşmedi");
        }

        [StepDefinition("Password alanının gizli olduğu görülür")]
        public void CheckIfPasswordShowDisabled()
        {
            Assert.IsTrue(loginModel.GetPasswordShowButtonValue().Contains("password"), "Password alanı gizli gelmedi");
        }

        [StepDefinition("Show Password butonuna tıklanır")]
        public void ClickShowPasswordButton()
        {
            loginModel.ClickShowPasswordButton();
        }

        [StepDefinition("Password alanının gizlenmediği görülür")]
        public void CheckIfPasswordShowEnabled()
        {
            Assert.IsTrue(loginModel.GetPasswordShowButtonValue().Contains("text"), "Password alanı görünür gelmedi");
        }

        [StepDefinition("Forgot Password butonuna tıklanır")]
        public void ClickForgotPassword()
        {
            loginModel.ClickForgotPassword();
        }

        [StepDefinition("Mail alanına '(.*)' yazılır")]
        public void SetTextForgotMail(string email)
        {
            loginModel.SetTextForgotMail(email);
        }

        [StepDefinition("Send butonuna tıklanır")]
        public void ClickSend()
        {
            loginModel.ClickSend();
        }

        [StepDefinition("'(.*)' mesajının geldiği görülür")]
        public void CheckIfForgotInfoMessage(string forgotInfoMessage)
        {
            Assert.IsTrue(loginModel.CheckIfForgotInfoMessage().Contains(forgotInfoMessage), "Şifremi unuttum hata mesajı doğru gelmedi");
        }

        [StepDefinition("'(.*)' mesajı görülür")]
        public void CheckIfForgotPasswordInfoMessage(string forgotInfoMessage)
        {
            Assert.IsTrue(loginModel.CheckIfForgotPasswordInfoMessage().Contains(forgotInfoMessage), "Şifremi unuttum mesajı doğru gelmedi");
        }

        [StepDefinition("Sign Up butonuna tıklanılır")]
        public void ClickSingUp()
        {
            loginModel.ClickSingUp();
        }

        [StepDefinition("Register sayfasının açıldığı görülür")]
        public void CheckIfHeadRegister()
        {
            Assert.IsTrue(loginModel.CheckIfHeadRegister(), "Register sayfası açılmadı");
        }

        [StepDefinition("'(.*)' elementin bulunduğu görülür")]
        public void ControlIsLoginElementVisible(string element)
        {
            Assert.IsTrue(loginModel.IsElementVisible(element), element + "elementi bulunamadı");
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
