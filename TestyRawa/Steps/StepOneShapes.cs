using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using static TestyRawa.DriverHelper.Browser;
using System.Linq;
namespace TestyRawa
{
    public class StepOneShapes
    {
        private ICollection<IWebElement> RoomParamsList => Driver.FindElements(By.XPath("//type[@number]"));
        private IList<IWebElement> ShapesRoomList => Driver.FindElements(By.XPath("//li[@shape-id]"));
        private IWebElement Room3DView => Driver.FindElement(By.XPath("//div[@class='room3dView']"));
        private IWebElement costam => Driver.FindElement(By.ClassName("asdasd"));
        public bool ViewRoomList()
        {
            WaitUntilElementIsDisplayed((By.XPath("//div[@class='room3dView']")), 5);
            ShapesRoomList.Select(e => e.GetAttribute("ACTIVE"));
            return ShapesRoomList.All((element) => 
            {
                element.Click();
                return element.GetAttribute("class").Equals("active");
            });

           
        }

 
    }
}
