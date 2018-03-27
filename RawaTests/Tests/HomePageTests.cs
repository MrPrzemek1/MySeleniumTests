using NUnit.Framework;
using RawaTests.Services;
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

        }
    }
}
