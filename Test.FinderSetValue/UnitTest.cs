using System.Collections.Generic;
using System.Linq;
using FinderSetValue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.FinderSetValue
{
    [TestClass]
    public class UnitTest
    {
        private readonly Finder _finder = new();

        [TestMethod]
        public void TestMethod()
        {
            //Arrange
            var list = new List<uint> {0, 1, 2, 3, 4, 5, 6, 7};
            ulong expectedSum = 11;

            //Act
            _finder.FindElementsForSum(list, expectedSum, out var start, out var end);

            //Assert
            Assert.IsTrue(start == 5);
            Assert.IsTrue(end == 7);
            Assert.AreEqual(expectedSum, SumRange(list, start, end));
        }

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var list = new List<uint> {4, 5, 6, 7};
            ulong expectedSum = 18;

            //Act
            _finder.FindElementsForSum(list, expectedSum, out var start, out var end);

            //Assert
            Assert.IsTrue(start == 1);
            Assert.IsTrue(end == 4);
            Assert.AreEqual(expectedSum, SumRange(list, start, end));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var list = new List<uint> {0, 1, 2, 3, 4, 5, 6, 7};
            ulong expectedSum = 88;

            //Act
            _finder.FindElementsForSum(list, expectedSum, out var start, out var end);

            //Assert
            Assert.IsTrue(start == 0);
            Assert.IsTrue(end == 0);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var list = new List<uint> {11};
            ulong expectedSum = 11;

            //Act
            _finder.FindElementsForSum(list, expectedSum, out var start, out var end);

            //Assert
            Assert.IsTrue(start == 0);
            Assert.IsTrue(end == 1);
            Assert.AreEqual(expectedSum, SumRange(list, start, end));
        }
        
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var list = new List<uint> {0};
            ulong expectedSum = 11;

            //Act
            _finder.FindElementsForSum(list, expectedSum, out var start, out var end);

            //Assert
            Assert.IsTrue(start == 0);
            Assert.IsTrue(end == 0);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            var list = new List<uint> {1, 2, 3, 4, 11};
            ulong expectedSum = 11;

            //Act
            _finder.FindElementsForSum(list, expectedSum, out var start, out var end);

            //Assert
            Assert.IsTrue(start == 4);
            Assert.IsTrue(end == 5);
            Assert.AreEqual(expectedSum, SumRange(list, start, end));
        }
        
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            var list = new List<uint> {1, 2, 11, 4, 5};
            ulong expectedSum = 11;

            //Act
            _finder.FindElementsForSum(list, expectedSum, out var start, out var end);

            //Assert
            Assert.IsTrue(start == 2);
            Assert.IsTrue(end == 3);
            Assert.AreEqual(expectedSum, SumRange(list, start, end));
        }
        
        [TestMethod]
        public void ReturnFirstOccurrence()
        {
            //Arrange
            var list = new List<uint> {1, 2, 3, 4, 1, 2};
            ulong expectedSum = 3;

            //Act
            _finder.FindElementsForSum(list, expectedSum, out var start, out var end);

            //Assert
            Assert.IsTrue(start == 0);
            Assert.IsTrue(end == 2);
            Assert.AreEqual(expectedSum, SumRange(list, start, end));
        }
        
        [TestMethod]
        public void ListIsNull()
        {
            //Arrange
            List<uint> list = null;
            ulong expectedSum = 11;

            //Act
            _finder.FindElementsForSum(list, expectedSum, out var start, out var end);

            //Assert
            Assert.IsTrue(start == 0);
            Assert.IsTrue(end == 0);
        }
        
        [TestMethod]
        public void ListIsEmpty()
        {
            //Arrange
            var list = new List<uint>();
            ulong expectedSum = 11;

            //Act
            _finder.FindElementsForSum(list, expectedSum, out var start, out var end);

            //Assert
            Assert.IsTrue(start == 0);
            Assert.IsTrue(end == 0);
        }

        private static ulong SumRange(List<uint> list, int start, int end) =>
            (ulong) list.ToArray()[start..end].Sum(x => x);
    }
}