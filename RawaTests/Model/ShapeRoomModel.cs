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
        public IWebElement ShapeOfRoom { get; set; }

        public string Id
        {
            get
            {
                return ShapeOfRoom.GetAttribute("shape-id");
            }
        }


    }
}
