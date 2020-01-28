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
            CustomList<T> ListOfMine = new CustomList<T>;
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
        
        }
    }
}
