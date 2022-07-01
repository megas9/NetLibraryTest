using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetLibraryTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetLibraryTest.Tests
{
    [TestClass()]
    public class AnyCalcTests
    {
        [TestMethod()]
        public void AnyFigureTest_cicle_13()
        {
            // arrange
            double a = 13;
            double expected = 530.929158456675;

            // act
            AnyCalc x = new AnyCalc();
            AnyCalc.Figure actual = x.AnyFigure(a);

            //assert
            Assert.AreEqual(expected, actual.area);
        }

        [TestMethod()]
        public void AnyFigureTest_rect_4_9_6()
        {
            // arrange
            double a = 4;
            double b = 9;
            double c = 6;
            double expected = 9.5;

            // act
            AnyCalc x = new AnyCalc();
            AnyCalc.Figure actual = x.AnyFigure(a, b, c);

            //assert
            Assert.AreEqual(expected, actual.area);
        }
    }
}