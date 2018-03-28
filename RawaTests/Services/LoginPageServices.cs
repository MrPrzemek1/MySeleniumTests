using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model;
using static TestyRawa.DriverHelper.Browser;

namespace RawaTests.Services
{
    class LoginPageServices
    {
        public LoginPageModel GetLoginPageModel()
        {
            var companyField = Driver.FindElement(By.XPath(HtmlLoginPageElements.CompanyInput));
            var loginField = Driver.FindElement(By.XPath(HtmlLoginPageElements.LoginInput));
            var passwordField = Driver.FindElement(By.XPath(HtmlLoginPageElements.PasswordInput));
            var loginBtn = Driver.FindElement(By.XPath(HtmlLoginPageElements.ButtonLogin));
            LoginPageModel model = new LoginPageModel(companyField, loginField, passwordField, loginBtn);
            return model;
        }

        public void SetCompanyName(LoginPageModel model,string companyName)
        {
            model.CompanyName.SendKeys(companyName);
        }
        public void SetLogin(LoginPageModel model, string login)
        {
            model.Login.SendKeys(login);
        }
        public void SetPassword(LoginPageModel model, string password)
        {
            model.Password.SendKeys(password);
        }
        public void SetLoginData(LoginPageModel model)
        {
            model.CompanyName.SendKeys(LoginData.CompanyName);
            model.Login.SendKeys(LoginData.Login);
            model.Password.SendKeys(LoginData.Password);
        }
    }
}

