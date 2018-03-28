﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Helpers
{
    public static class HtmlLoginPageElements
    {
        public static string CompanyInput = "//input[@placeholder='Nazwa firmy']";
        public static string LoginInput = "//input[@placeholder='Nazwa pracownika']";
        public static string PasswordInput = "//input[@placeholder='Hasło']";
        public static string LoginForm = "//div[@class=' form-login-bg']";
        public static string Logout = "div-logout";
        public static string ButtonLogin = "//input[@class='btn btn-primary btn-lg btn-login']";
    }
}