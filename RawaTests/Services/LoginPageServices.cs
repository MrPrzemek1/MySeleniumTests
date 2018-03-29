using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model;
using static TestyRawa.DriverHelper.Browser;

namespace RawaTests.Services
{
    class LoginPageServices
    {
        public IWebElement validateField;
        public LoginPageModel GetLoginPageModel()
        {
            var companyField = Driver.FindElement(By.XPath(HtmlLoginPageElements.CompanyInput));
            var loginField = Driver.FindElement(By.XPath(HtmlLoginPageElements.LoginInput));
            var passwordField = Driver.FindElement(By.XPath(HtmlLoginPageElements.PasswordInput));
            var loginBtn = Driver.FindElement(By.XPath(HtmlLoginPageElements.ButtonLogin));

            LoginPageModel model = new LoginPageModel(companyField, loginField, passwordField, loginBtn);
            return model;
        }
        public void SetLoginData(LoginPageModel model)
        {
            model.CompanyName.SendKeys(LoginData.CompanyName);
            model.Login.SendKeys(LoginData.Login);
            model.Password.SendKeys(LoginData.Password);
        }
        public bool ValidateFieldIsDisplayed()
        {
            validateField = Driver.FindElement(By.XPath(HtmlLoginPageElements.ValidateField));
            if (validateField.Displayed)
            {
                return true;
            }
            return false;
        }
        public string GetValidateText()
        {
            bool isPresent = ValidateFieldIsDisplayed();
            if (isPresent == true)
            {
                string text = validateField.Text;
                return text;
            }
            return null;
        }
        public LoginPageModel ClearAllLoginForField(LoginPageModel model)
        {
            model.CompanyName.Clear();
            model.Login.Clear();
            model.Password.Clear();
            return new LoginPageModel(model.CompanyName,model.Login,model.Password,model.LoginButton);
        }
        public void SetLoginData(string company, string login, string pass)
        {
            var model = GetLoginPageModel();
            model.CompanyName.SendKeys(company);
            model.Login.SendKeys(login);
            model.Password.SendKeys(pass);
        }

    }
}

