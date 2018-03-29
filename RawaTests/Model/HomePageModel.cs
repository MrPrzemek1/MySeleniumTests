using OpenQA.Selenium;

namespace RawaTests.Model
{
    class HomePageModel
    {
        public IWebElement StartButton { get; set; }
        public IWebElement HomePageImage { get; set; }
        public IWebElement LogoImage { get; set; }
        public IWebElement Footer { get; set;}
        public IWebElement LoginBtn { get; set; }
        public HomePageModel(IWebElement button, IWebElement homeImg, IWebElement logoImg, IWebElement footer, IWebElement loginBtn)
        {
            StartButton = button;
            HomePageImage = homeImg;
            LogoImage = logoImg;
            Footer = footer;
            LoginBtn = loginBtn;
        }
    }
}
