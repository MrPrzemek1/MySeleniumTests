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
        public void VerifyChangeClassForShapes()
        {
           Assert.IsTrue(ViewRoomList());
        }

        [Test, Description("Sprawdzenie czy po kliknieciu na przycisk + i zmianie wartości w pole inne pole zależne od niego również zmienia wartość."), Order(2)]
        public void Test()
        {
            CheckInputWasChanged();
            Assert.AreEqual("wallSizeInput changed", Browser.GetElementAttribute(By.XPath("//input[@name='3' and @type='number']"), "class"));
        }
    }
}
