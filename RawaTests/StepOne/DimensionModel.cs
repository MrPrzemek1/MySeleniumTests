using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using static TestyRawa.DriverHelper.Browser;
namespace RawaTests.StepOne
{
    class DimensionModel : IComparable<DimensionModel>
    {
        public string Name { get; set; }
        public IWebElement MinusSign { get; set; }
        public IWebElement PlusSign { get; set; }
        public IWebElement Input { get; set; }

        public int CompareTo(DimensionModel obj)
        {
            return this.Name.CompareTo(obj.Name);
        }
    }
}
