using OpenQA.Selenium;
using RawaTests.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Model
{
    public class ShapeRoomModel
    {
       // public int[6] NumberOfShapes { get; set; }
        public IWebElement ShapeID { get; set; }
        public IWebElement Header { get; set; }
        public IWebElement Source { get; set; }
        public IWebElement ClassName { get; set; }

        public string Id
        {
            get
            {
                return ShapeID.GetAttribute("shape-id");
            }
        }


    }
}
