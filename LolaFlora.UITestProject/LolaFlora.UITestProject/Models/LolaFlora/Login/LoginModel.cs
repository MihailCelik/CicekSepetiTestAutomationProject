using OpenQA.Selenium;

namespace LolaFlora.UITestProject.Models.LolaFlora.Login
{
    public class LoginModel
    {
        private BasePage basePage;
        bool isElementVisible;

        public LoginModel(IWebDriver driver)
        {
            basePage = new BasePage(driver);
        }

        By hdSignIn = By.XPath("//h2[contains(text(),'Sign In')]");
        By txtEmail = By.Id("EmailLogin");
        By txtpassword = By.Id("Password");
        By btnSignIn = By.XPath("//button[contains(text(),'Sign In')]");
        By btnMyAccount = By.XPath("(//span[contains(text(),'My Account')])[1]");
        By txtAlertMessage = By.ClassName("modal-body");
        By btnOk = By.XPath("//button[contains(text(),'Ok')]");
        By txtEmailAlertMessage = By.Id("EmailLogin-error");
        By txtPasswordAlertMessage = By.Id("Password-error");
        By btnShowPassword = By.ClassName("js-show-type");
        By btnForgotPassword = By.ClassName("login__forgot-password");
        By txtForgotMail = By.Id("Mail");
        By btnSend = By.ClassName("js-password-recovery-button");
        By txtForgotInfoMessage = By.Id("Mail-error");
        By txtForgotPasswordInfoMessage = By.XPath("//span[@class='password-recovery-result__icon icon-check']");
        By btnSignUp = By.XPath("/html/body/main/div/div[2]/div/a");
        By hdRegister = By.XPath("//h2[contains(text(),'Register')]");
        By btnFacebook = By.ClassName("login__facebook");

        public void OpenLoginPage(string url)
        {
            basePage.NavigateUrl(url);
        }

        public bool CheckIfHeadSignIn()
        {
            return basePage.IsElementVisible(hdSignIn);
        }

        public void SetTextEmail(string email)
        {
            basePage.SendKeys(txtEmail, email);
        }

        public void SetTextPassword(string password)
        {
            basePage.SendKeys(txtpassword, password);
        }

        public void ClickSignIn()
        {
            basePage.ClickElement(btnSignIn);
        }

        public bool CheckIfLoginIsMyAccountVisible()
        {
            basePage.WaitFromSeconds(3);
            return basePage.IsElementVisible(btnMyAccount);
        }

        public string CheckIfAlertMessage()
        {
            basePage.WaitFromSeconds(2);
            return basePage.GetText(txtAlertMessage);
        }

        public void ClickOk()
        {
            basePage.ClickElement(btnOk);
        }

        public string ControlEmptyEmailAlertMessage()
        {
            return basePage.GetText(txtEmailAlertMessage);
        }

        public string ControlEmptyPasswordAlertMessage()
        {
            return basePage.GetText(txtPasswordAlertMessage);
        }

        public string GetPasswordShowButtonValue()
        {
            return basePage.GetAttribute(txtpassword, "type");
        }

        public void ClickShowPasswordButton()
        {
            basePage.ClickElement(btnShowPassword);
        }

        public void ClickForgotPassword()
        {
            basePage.ClickElement(btnForgotPassword);
        }

        public void SetTextForgotMail(string email)
        {
            basePage.SendKeys(txtForgotMail, email);
        }

        public void ClickSend()
        {
            basePage.ClickElement(btnSend);
        }

        public string CheckIfForgotInfoMessage()
        {
            return basePage.GetText(txtForgotInfoMessage);
        }

        public string CheckIfForgotPasswordInfoMessage()
        {
            return basePage.GetText(txtForgotPasswordInfoMessage);
        }

        public void ClickSingUp()
        {
            basePage.DragAndDropToOffset(btnSignUp);
            basePage.ClickElement(btnSignUp);
        }

        public bool CheckIfHeadRegister()
        {
            return basePage.IsElementVisible(hdRegister);
        }

        public bool IsElementVisible(string element)
        {
            isElementVisible = false;
            switch (element)
            {
                case "Email":
                    isElementVisible = basePage.IsElementVisible(txtEmail);
                    break;
                case "Password":
                    isElementVisible = basePage.IsElementVisible(txtpassword);
                    break;
                case "Sign In":
                    isElementVisible = basePage.IsElementVisible(btnSignIn);
                    break;
                case "Forgot Password":
                    isElementVisible = basePage.IsElementVisible(btnForgotPassword);
                    break;
                case "Sign in with Facebook":
                    isElementVisible = basePage.IsElementVisible(btnFacebook);
                    break;
                case "Sign Up":
                    isElementVisible = basePage.IsElementVisible(btnSignUp);
                    break;
                default: throw new InvalidElementStateException(element);
            }
            return isElementVisible;
        }
    }
}
