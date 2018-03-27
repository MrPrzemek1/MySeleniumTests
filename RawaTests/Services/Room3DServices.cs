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
    class Room3DServices : IEquatable<Room3DDimensionsWalls>
    {
        public Room3DViewModel Get3DModel()
        {
            var model = Driver.FindElement(By.ClassName("letter"));
            //var dimension = Driver.FindElements(By.ClassName("letter"));

            Room3DViewModel room3D = new Room3DViewModel();
            room3D.Room3DImage = model;
            return room3D;
        }

        public string GetDimStyle(Room3DViewModel a)
        {
            string art;
            art =  a.Room3DImage.GetAttribute("style");
            return art;
        }

        //public List<string> GetStyle(Room3DViewModel model)
        //{
        //    var a = Get3DModel();
        //    List<string> list = new List<string>();
        //    for (int i = 0; i < a.Dimension.Count; i++)
        //    {
        //        list.Add(model.Room3DImage.Text);
        //    }
        //    return list;
        //}

        public bool Equals(Room3DDimensionsWalls other)
        {
            var model = Get3DModel();
            if (other.Equals(model))
            {
                return true;
            }
            return false;
        }
    }
}
