using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZheleznyakDN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ZheleznyakDN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Дамир";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Дамир", res);
        }
    }
}
