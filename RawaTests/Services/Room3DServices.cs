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
        public Room3DViewModel Get3DModel()
        {
            var model = Driver.FindElement(By.ClassName("letter"));
            Room3DViewModel room3D = new Room3DViewModel();
            room3D.Room3DImage.Element = model;
            return room3D;
        }

        public string GetRoomAttribute(string attributeName, Room3DViewModel a)
        {
            string art;
            art = a.Room3DImage.Element.GetAttribute(attributeName);
            return art;
        }
    }
}
