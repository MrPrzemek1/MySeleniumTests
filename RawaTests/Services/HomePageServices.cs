using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper.Browser;
using OpenQA.Selenium;
using RawaTests.Model;

namespace RawaTests.Services
{
    class HomePageServices
    {
        public HomePageModel GetHomePageModel()
        {
            var startButton = Driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-lg btn-start']"));
            var homeImg = Driver.FindElement(By.ClassName("img-responsive"));
            var logoImg = Driver.FindElement(By.ClassName("logo"));
            HomePageModel homeModel = new HomePageModel(startButton, homeImg, logoImg);
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
    }
}
