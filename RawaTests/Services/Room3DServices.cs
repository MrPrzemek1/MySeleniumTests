using OpenQA.Selenium;
using RawaTests.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper.Browser;

namespace RawaTests.Services
{
    class Room3DServices
    {
        public Room3DDimensionsWalls Get3DModel()
        {
            var model = Driver.FindElements(By.ClassName("room3dView"));
            //var dimension = Driver.FindElements(By.ClassName("letter"));

            Room3DDimensionsWalls room3D = new Room3DDimensionsWalls();
            for (int i = 0; i < model.Count; ++i)
            {
                room3D.Model3D.Add(new Room3DViewModel
                {
                    Room3DImage = model[i],
                });

            }
            return room3D;
        }

        public List<IWebElement> GetModelDimension(Room3DDimensionsWalls model)
        {
            List<IWebElement> Dimension = new List<IWebElement>();
            foreach (var item in Dimension)
            {
                item.GetAttribute("letter");
            }
            return Dimension;
        }
    }
}
