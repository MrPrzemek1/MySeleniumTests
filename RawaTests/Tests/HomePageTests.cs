using NUnit.Framework;
using RawaTests.Services;
using RawaTests.Tests.Base;
using static TestyRawa.DriverHelper;

namespace RawaTests.Tests
{
    [TestFixture]
    class HomePageTests
    {
        HomePageServices homePageSrv;
        HomePageTests()
        {
            homePageSrv = new HomePageServices();
        }
        
        [SetUp]
        public void TestInizialize()
        {
            Browser.Initialize();
        }
        [TearDown]
        public void EndTest()
        {
            Browser.Quit();
        }
        [Test]
        public void ButtonStartIsDisplayed()
        {
            var homeModel = homePageSrv.GetHomePageModel();
            Assert.IsTrue(homeModel.StartButton.Displayed);
            Assert.IsTrue(homeModel.LogoImage.Displayed);
            Assert.IsTrue(homeModel.HomePageImage.Displayed);
        }
    }
}
