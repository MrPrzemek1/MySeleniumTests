using OpenQA.Selenium;
using RawaTests.Lists;
using RawaTests.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper.Browser;

namespace RawaTests.Services
{
    class ShapeRoomServices
    {
        public ShapeRoomList GetShapes()
        {
            var shape_id = Driver.FindElements(By.XPath("//li[@shape-id]"));

            ShapeRoomList listOfShapes = new ShapeRoomList();
            int i = 0;
            foreach (var item in shape_id)
            {
                listOfShapes.Shapes.Add(new ShapeRoomModel
                {
                    ShapeID = shape_id[i],
                });
                i++;
            }
            return listOfShapes;
        }
        public ShapeRoomModel GetShapeByID(string id)
        {
            var usedShape = GetShapes();
            return usedShape.Shapes.Where(e => e.Id == id).FirstOrDefault();
        }

        public string GetUsedShapeClass(ShapeRoomModel room)
        {
            return room.ShapeID.GetAttribute("class");
        }
    }
}
