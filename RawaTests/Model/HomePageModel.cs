using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Model
{
    class HomePageModel
    {
        public IWebElement StartButton { get; set; }
        public IWebElement HomePageImage { get; set; }
        public IWebElement LogoImage { get; set; }
        public IWebElement Footer { get; set;}
        public HomePageModel(IWebElement button, IWebElement homeImg, IWebElement logoImg, IWebElement footer)
        {
            StartButton = button;
            HomePageImage = homeImg;
            LogoImage = logoImg;
            Footer = footer;
        }
    }
}
