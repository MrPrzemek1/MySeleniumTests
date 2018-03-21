using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper;

namespace TestyRawa
{
    [TestFixture]
    class StepOneTests : StepOneShapes
    {
        [OneTimeSetUp]
        public void TestInizialize()
        {
            Browser.Initialize();
            Browser.WaitUntilElementIsDisplayed(By.XPath("//button[@class='btn btn-primary btn-lg btn-start']"), 5);
            Browser.ClickOnElement(By.XPath("//button[@class='btn btn-primary btn-lg btn-start']"));
        }
        [OneTimeTearDown]
        public void EndTest()
        {
            Browser.Quit();
        }
        [Test,Description("Przeglądanie kształtów pomieszczeń"),Order(1)]
        public void Test()
        {
           Assert.IsTrue(ViewRoomList());
        }
    }
}
