﻿using OpenQA.Selenium;
using RawaTests.Helpers;
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
        /// <summary>
        /// Metoda wybierająca jeden z kształtów pomieszczeń
        /// </summary>
        /// <param name="id">id pomieszczenia ktore chcemy wybrac</param>
        /// <returns></returns>
        public ShapeRoomModel GetShapeByID(string id)
        {
            var usedShape = GetShapes();
            return usedShape.Shapes.Where(e => e.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Metoda zwracająca wybrany atrybut HTML
        /// </summary>
        /// <param name="attributeName">nazwa atrybutu html ktory chcemy pobrac</param>
        /// <param name="room">Aktywny kształt pomieszczenia</param>
        /// <returns></returns>
        public string GetUsedShapeAttribute(string attributeName,ShapeRoomModel room)
        {
            return room.ShapeID.Element.GetAttribute(attributeName);
        }
    }
}
