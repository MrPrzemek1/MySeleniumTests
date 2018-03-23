using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper;

namespace RawaTests.Tests.Base
{
    [TestFixture]
    public abstract class BaseTest
    {
        public BaseTest()
        {
            
        }

        public abstract void Init();

        public abstract void End();
        [SetUp]
        public void TestInizialize()
        {
            Browser.Initialize();
            Browser.ClickOnElement(By.XPath("//button[@class='btn btn-primary btn-lg btn-start']"));
            Browser.WaitUntilElementIsDisplayed(By.XPath("//input[@class='btn-inc']"), 5);

            Init();
        }
        [TearDown]
        public void EndTest()
        {
            End();
            Browser.Quit();
        }
    }
}
