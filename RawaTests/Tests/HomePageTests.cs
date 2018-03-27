using NUnit.Framework;
using RawaTests.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper;

namespace RawaTests.Tests
{
    [TestFixture]
    class HomePageTests
    {
        HomePageServices homePageSrv;
        HomePageTests()
        {
            homePageSrv = new HomePageModel
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
