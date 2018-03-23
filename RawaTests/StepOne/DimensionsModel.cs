using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper.Browser;

namespace RawaTests.StepOne
{
   class DimensionsModel : IEnumerable<DimensionModel>, IEnumerable, IComparable<DimensionsModel>
    {
        public List<DimensionModel> Elements { get; set; }

        public DimensionsModel()
        {
            Elements = new List<DimensionModel>();
        }

        //public static  DimensionsModel Build()
        //{
        //    DimensionsModel result = new DimensionsModel();
        //    var btnPlus = Driver.FindElements(By.XPath("//input[@class='btn-inc']"));
        //    var btnMinus = Driver.FindElements(By.XPath("//input[@class='btn-dec']"));
        //    var letter = Driver.FindElements(By.XPath("//label[@class='set-room-params-letters']"));
        //    var inputField = Driver.FindElements(By.XPath("//input[@class='wallSizeInput']"));

        //    for (int i = 0; i < btnPlus.Count; ++i)
        //    {
        //        result.Elements.Add(new DimensionModel
        //        {
        //            PlusSign = btnPlus[i],
        //            MinusSign = btnMinus[i],
        //            Input = inputField.Count > i ? inputField[i] : null,
        //            Name = letter.Count > i ? letter[i].Text : null
        //        });
        //    }

        //    return result;
        //}

        public DimensionModel GetDimension(string name)
        {
            return Elements.Where(e => e.Name == name).FirstOrDefault();
        }

        public DimensionModel this[string name]
        {
            get
            {
                return Elements.Where(e => e.Name == name).FirstOrDefault();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this.Elements.GetEnumerator();
        }

        IEnumerator<DimensionModel> IEnumerable<DimensionModel>.GetEnumerator()
        {
            return this.Elements.GetEnumerator();
        }

        public int CompareTo(DimensionsModel other)
        {
            return this.Count().CompareTo(other.Count());
        }
        //public static bool CompareModel(DimensionsModel a , DimensionsModel b)
        //{
        //    return a.Elements.Count = 
        //}
    }
}
