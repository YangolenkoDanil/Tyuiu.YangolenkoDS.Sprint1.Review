using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint1.TaskReview.V22.Lib;

namespace Tyuiu.YangolenkoDS.Sprint1.TaskReview.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 6;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.186, Math.Round(res, 3));
        }
    }
}
