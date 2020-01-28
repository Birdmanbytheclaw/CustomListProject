using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProj;

namespace CustomListClassTestRemove
{
    [TestClass]
    public class RemoveClass
    {
        [TestMethod]
        public void EmoveItemWhileCapacityStaysAtFour()
        {

            //Arrange
            CustomList<int> ListOfMine = new CustomList<int>();
            int TheValue = 5;
            int actual;
            int TheExpected = 4;
            //Act
            ListOfMine.Add(TheValue);
            ListOfMine.Remove(TheValue);
            actual = ListOfMine.Capacity;
            //Assert
            Assert.AreEqual(TheExpected, actual);

        }
        [TestMethod]
        public void RemoveZeroButCountStaysAtOne()
        {
            //Arrange
            CustomList<int> ListOfMine = new CustomList<int>();
            int Value = 5;
            int RemoveValue = 0;
            int actual;
            int TheExpected = 1;
            //Act
            ListOfMine.Add(Value);
            ListOfMine.Remove(RemoveValue);
            actual = ListOfMine.Count;
            //Assert
            Assert.AreEqual(TheExpected, actual);
        }
        [TestMethod]
        public void RemoveFirstOfTwoThenSecondMovesToIndexZero()
        {

            //Arrange
            CustomList<int> ListOfMine = new CustomList<int>;
            int ValueOne = 5;
            int ValueTwo = 10;
            int actual;
            int expected = 10;
            //Act
            ListOfMine.Add(ValueOne);
            ListOfMine.Add(ValueTwo);
            ListOfMine.Remove(ValueOne);
            actual = ListOfMine[0];
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]


    }
}
