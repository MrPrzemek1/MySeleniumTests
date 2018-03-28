using NUnit.Framework;
using OpenQA.Selenium;
using RawaTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper;

namespace RawaTests.Tests.Base
{
    [TestFixture]
    public abstract class BaseTest : IDriverService
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
            Browser.ClickOnElement(By.XPath(HTMLConsts.BUTTONSTART));
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
