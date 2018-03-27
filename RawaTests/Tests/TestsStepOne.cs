﻿using RawaTests.StepOne;
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
using RawaTests.Helpers;

namespace RawaTests.Tests
{
    class TestsStepOne : BaseTest
    {
        private DimensionServices dimensionSrv;
        private ShapeRoomServices shapeRoomSrv;
        private Room3DServices room3dSrv;
        public TestsStepOne()
        {
            dimensionSrv = new DimensionServices();
            shapeRoomSrv = new ShapeRoomServices();
            room3dSrv = new Room3DServices();
        }
        
        public override void End()
        {
            
        }

        public override void Init()
        {
            
        }
        /// <summary>
        /// Test sprawdzajacy czy po kilknieciu w kształt pomieszczenia jego klasa zmienia sie na active
        /// </summary>
        public void VerifyClickedElementChangeClass()
        {
            string expectedClass = "active";
            var usedShape = shapeRoomSrv.GetShapeByID("30");
            usedShape.ShapeID.Click();
            var usedShapeClass = shapeRoomSrv.GetUsedShapeAttribute(HTMLConsts.CLASS,usedShape);
            Assert.AreEqual(expectedClass, usedShapeClass);

        }
        /// <summary>
        /// Test sprawdzający czy po kliknięciu w button do zwiększenia wymiarów pomieszczenia zmieniają się wymiary obrazka.
        /// </summary>
        [Test]
        public void VerifyImageSizeWasChangeAfterChangeDimension()
        { 
            var usedShape = shapeRoomSrv.GetShapeByID("30");
            usedShape.ShapeID.Click();
            var firstModel = room3dSrv.Get3DModel();
            dimensionSrv.GetDimensionModelByName("B").PlusSign.Click();
            var modelAfterClick = room3dSrv.Get3DModel();       
            Assert.IsFalse(modelAfterClick.Room3DImage.Style.Equals(firstModel.Room3DImage.Style));
        }
        [Test]
        public void VerifyImageChangedAfterClickOnShape()
        {
            shapeRoomSrv.GetShapeByID("30").ShapeID.Click();

        }
    }
}