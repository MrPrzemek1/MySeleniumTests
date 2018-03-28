﻿using NUnit.Framework;
using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper;
using static TestyRawa.DriverHelper.Browser;

namespace RawaTests.Tests
{
    [TestFixture(Category ="LoginPageTests")]
    class LoginPageTests
    {
        LoginPageServices loginSrv;
        HomePageServices homeSrv;

        public LoginPageTests()
        {
            loginSrv = new LoginPageServices();
            homeSrv = new HomePageServices();
        }

        [OneTimeSetUp]
        public void TestInizialize()
        {
            Browser.Initialize();
            Driver.FindElement(By.ClassName(HtmlHomePageElements.Login)).Click();
            WaitUntilElementIsDisplayed(By.XPath(HtmlLoginPageElements.LoginForm),5);
        }
        [OneTimeTearDown]
        public void EndTest()
        {
            Browser.Quit();
        }
        [Test,Description("asdas")]
        public void CorrectLogin()
        {
            var model = loginSrv.GetLoginPageModel();
            loginSrv.SetLoginData(model);
            model.LoginButton.Click();
            WaitUntilElementIsDisplayed(By.XPath(HtmlHomePageElements.ButtonStart), 5);
            Assert.IsTrue(Driver.FindElement(By.XPath(HtmlLoginPageElements.LogoutButton)).Displayed);
        }
        [Test]
        public void VerifyingValidateAlerts()
        {
            var model = loginSrv.GetLoginPageModel();
            var homePage = homeSrv.GetHomePageModel();
            homeSrv.ClickOnLoginButton(homePage);

            WaitUntilElementIsDisplayed(By.XPath(HtmlHomePageElements.ButtonStart), 5);
           
            model.Login.SendKeys(LoginData.Login);
            model.Password.SendKeys(LoginData.Password);
            model.LoginButton.Click();

            var validateField = Driver.FindElement(By.XPath(HtmlLoginPageElements.ValidateField));
            if (validateField.Displayed)
            {

                Assert.AreEqual("Pole nazwa firmy jest obowiązkowe", validateField.Text);
            }



        }


    }
}
