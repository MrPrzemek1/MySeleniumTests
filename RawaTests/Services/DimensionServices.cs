using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper.Browser;
namespace RawaTests.StepOne
{
    class DimensionServices
    {
        public DimensionsList GetDimensions()
        {
           var btnPlus =  Driver.FindElements(By.XPath("//input[@class='btn-inc']"));
           var btnMinus = Driver.FindElements(By.XPath("//input[@class='btn-dec']"));
           var letter = Driver.FindElements(By.XPath("//label[@class='set-room-params-letters']"));
           var inputField = Driver.FindElements(By.XPath("//input[@class='wallSizeInput']"));

            DimensionsList result = new DimensionsList();

            for(int i=0; i< btnPlus.Count; ++i)
            {
                result.Elements.Add(new DimensionModel
                {
                    PlusSign = btnPlus[i],
                    MinusSign = btnMinus[i],
                    Input = inputField.Count > i ? inputField[i]  : null,
                    Name = letter.Count > i ? letter[i].Text : null
                });
            }
            return result;
        }
        /// <summary>
        /// Metoda zwracająca model elementu w którym możemy modyfikować wielkość pomieszczenia
        /// </summary>
        /// <param name="name">etykieta wymiaru np: "A"</param>
        /// <returns></returns>
        public DimensionModel GetDimensionModelByName(string name)
        {
            var dims = GetDimensions();
            return dims.Elements.Where(e => e.Name == name).FirstOrDefault();
        }
    }
}
