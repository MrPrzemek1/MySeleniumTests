﻿using static TestyRawa.DriverHelper.Browser;
using OpenQA.Selenium;
using RawaTests.Model;
using RawaTests.Helpers;
using System;

namespace RawaTests.Services
{
    class HomePageServices
    {
        IWebElement logoutDiv;
        public HomePageModel GetHomePageModel()
        {
            var startButton = Driver.FindElement(By.XPath(HtmlHomePageElements.ButtonStart));
            var homeImg = Driver.FindElement(By.ClassName(HtmlHomePageElements.HomePageImage));
            var logoImg = Driver.FindElement(By.ClassName(HtmlHomePageElements.HomePageLogo));
            var footer = Driver.FindElement(By.XPath(HtmlHomePageElements.Footer));
            var loginBtn = Driver.FindElement(By.XPath(HtmlHomePageElements.LoginButton));

            HomePageModel homeModel = new HomePageModel(startButton, homeImg, logoImg, footer, loginBtn);
            return homeModel;
        }
        public bool StartButtonIsDisplay(HomePageModel model)
        {
            if (!model.StartButton.Displayed || model.StartButton==null)
            {
                return false;
            }
            return true;
        }
        public void ClickOnLoginButton(HomePageModel model)
        {
            model.LoginBtn.Click();
        }
        public bool isElementExist()
        {
            try
            {
                logoutDiv = Driver.FindElement(By.XPath(HtmlHomePageElements.LogoutDiv));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
