using RawaTests.StepOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static TestyRawa.DriverHelper;
using OpenQA.Selenium;
using RawaTests.Tests.Base;
using RawaTests.Services;

namespace RawaTests.Tests
{
    class TestRoom : BaseTest
    {
       private DimensionServices dimensionSrv;
       private ShapeRoomServices roomServices;
        private Room3DServices room3dSrv;
        public TestRoom()
        {
            dimensionSrv = new DimensionServices();
            roomServices = new ShapeRoomServices();
            room3dSrv = new Room3DServices();
        }

        public override void End()
        {
            
        }

        public override void Init()
        {
            
        }

        [Test]
        public void TestMethodd()
        {
            //var aDim = this.dimensionSrv.GetDimensionModelByName("A");

            //if(aDim != null)
            //{
            //    aDim.PlusSign.Click();
            //}
            //Browser.ClickOnElement(By.XPath("//input[@class='btn-inc']"));
            

        }

        [Test]
        public void TestMethodd2()
        {
            //var dimens = DimensionsModel.Build();

            //dimens.GetDimension("B").MinusSign.Click();

        }

        [Test]
        public void TestMethodd3()
        {
            var aDim = this.dimensionSrv.GetDimensions();

            var element = aDim.GetDimension("A");

            element.PlusSign.Click();

        }

        [Test]
        public void TestMethodd4()
        {
            var aDim = this.dimensionSrv.GetDimensions();

            foreach(DimensionModel elem in aDim)
            {
                elem.MinusSign.Click();
            }
        }

        [Test]
        public void TestMethodd5()
        {
            var aDim = this.dimensionSrv.GetDimensions();

            aDim["B"].MinusSign.Click();
        }

        [Test]
        public void TestMethodd6()
        {
            var aDim1 = this.dimensionSrv.GetDimensions();

            var aDim2 = this.dimensionSrv.GetDimensions();

            var b1 = aDim1["B"];
            var b2 = aDim2["B"];

            var a1 = aDim1["A"];
            
            var r1 = b1 == b2;
            var r2 = a1 == b2;

            var eeeee = aDim1 == aDim2;
        }
        [Test]
        public void TestMethod1()
        {
            string expectedClass = "active";
            var usedShape = roomServices.GetShapeByID("30");
            usedShape.ShapeID.Click();
            var usedShapeClass = roomServices.GetUsedShapeClass(usedShape);
            Assert.AreEqual(expectedClass, usedShapeClass);

        }
        [Test]
        public void TestMethod2()
        { 
            var usedShape = roomServices.GetShapeByID("30");
            usedShape.ShapeID.Click();
            var a = room3dSrv.Get3DModel();
            List<IWebElement> list = room3dSrv.GetModelDimension(a);
        }
    }
}
