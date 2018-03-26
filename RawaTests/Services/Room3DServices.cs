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
        public Room3DDimensionsWalls Get3DModel()
        {
            var model = Driver.FindElements(By.ClassName("letter"));
            //var dimension = Driver.FindElements(By.ClassName("letter"));

            Room3DDimensionsWalls room3D = new Room3DDimensionsWalls();
            for (int i = 0; i < model.Count; ++i)
            {
                room3D.Dimension.Add(new Room3DViewModel
                {
                    Room3DImage = model[i],
                });

            }
            return room3D;
        }

        public Room3DViewModel GetDimStyle(string art)
        {
            var dim = Get3DModel();
            var dim2 = dim.Dimension.Select(e=>e.Room3DImage.GetAttribute("letter"));
            List<Room3DViewModel> asd = new List<Room3DViewModel>();
            return dim2;
        }

        public List<string> GetStyle(Room3DViewModel model)
        {
            var a = Get3DModel();
            List<string> list = new List<string>();
            for (int i = 0; i < a.Dimension.Count; i++)
            {
                list.Add(model.Room3DImage.Text);
            }
            return list;
        }

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
