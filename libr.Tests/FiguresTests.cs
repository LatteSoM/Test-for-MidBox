using FiguresLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace libr.Tests
{
    [TestClass]
    public class FiguresTests
    {
        [TestMethod]
        public void CircleArea_15_707returned()
        {
            double expected = 706.80f, actual, delta = 0.1f;
            double testInp = 15;
            actual = Figures.CircleArea(testInp);
            Assert.AreEqual(expected, actual, delta,
                $"сравниваю число {expected} и {actual} где дельта {delta}");
        }

        [TestMethod]
        public void TriangleArea_12point3_15point6_11point1_707returned() 
        {
            double expected = 68, actual;
            double testA = 12.3;
            double testB = 15.6;
            double testC = 11.1;
            actual = Figures.TriangleArea(testA, testB, testC);
            Assert.AreEqual(expected, actual);
        }
    }
}
