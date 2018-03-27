using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests
{
    class Room3DViewModel
    {
        public IWebElement Room3DImage { get; set; }
        //public IWebElement DimensionSingleWall { get; set; }
        public Room3DViewModel()
        {
            Room3DImage = null;

        }
        public string Style { get { return Room3DImage.GetAttribute(HTMLConsts.STYLE); } }

    }

}
