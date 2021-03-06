﻿using OpenQA.Selenium;

namespace RawaTests.Model
{
    class LoginPageModel
    {
        public IWebElement CompanyName { get; set; }
        public IWebElement Login { get; set; }
        public IWebElement Password { get; set; }
        public IWebElement LoginButton { get; set; }
        public LoginPageModel(IWebElement company, IWebElement login, IWebElement pass, IWebElement loginBtn)
        {
            CompanyName = company;
            Login = login;
            Password = pass;
            LoginButton = loginBtn;
        }
    }
}
