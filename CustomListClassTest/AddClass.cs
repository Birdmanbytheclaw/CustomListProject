using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProj;

namespace CustomListClassTest
{
    
    [TestClass]
    public class AddClass
    {
       
        [TestMethod]
        public void AddMethod_FirstThingAdded_zeroIndex()
        {
            //Arrange
            CustomList<int> ListOfMine = new CustomList<int>();
            int actual;
            int expected = 7;
            //Act
        
        ListOfMine.Add(7);
            actual = ListOfMine[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_SecondThingAdded_IndexOne()
        {
            //arrange
            CustomList<int> ListOfMine = new CustomList<int>();
            int actual;
            int expected = 2;

            //act
            ListOfMine.Add(7);
            ListOfMine.Add(2);
            actual = ListOfMine[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListIndexNumberCount()
        {
            //Test Count
            //Arrange
            CustomList<int> ListOfMine = new CustomList<int>();
            int StartingPoint = 2;
            int actual;
            int expected = 1;

            //ActL
            ListOfMine.Add(StartingPoint);        
            actual = ListOfMine.Count;
            //Assertf
            Assert.AreEqual(expected, actual);
        }
        //Make sure 0 does not get overwritten
        [TestMethod]
        public void CheckingZeroIndewForOverwtite()
        {
            //Arrange
            CustomList<int> ListOfMine = new CustomList<int>();
            int actual;
            int Value = 2;
            int SecondValue = 17;
            //Act
        
            ListOfMine.Add(Value);
            ListOfMine.Add(SecondValue);
            actual = ListOfMine[1];

            //Assert
            Assert.AreEqual(SecondValue, actual);

        }
        //test adding the same thing twice and both exist
        [TestMethod]
        public void AddingSameThingTwice()
        {          
            //Arrange            
            CustomList<string> ListOfMine = new CustomList<string>();

           
           
            string ValueZero = "Hello";
            string Actual;
            
            //Act
            ListOfMine.Add(ValueZero);
            ListOfMine.Add(ValueZero);
            ListOfMine.Add(ValueZero);
            ListOfMine.Add(ValueZero);
            ListOfMine.Add(ValueZero);
            ListOfMine.Add(ValueZero);
            ListOfMine.Add(ValueZero);
            Actual = ListOfMine[6];

            //Assert
            Assert.AreEqual(ValueZero, Actual);
        
        }
        //test capacity Growth after 5 are added
        [TestMethod]
        public void GrowCapacityToCheckForStoredValue ()
        {
        //Arrange
        CustomList<string> ListOfMine = new CustomList<string>();
        string elephants = "elephants";
        string are = "are";
        string dancing = "dancing";
        string get = "get";
        string back = "back";
        int actual;
        int expected = 8;
        //Act
        ListOfMine.Add(elephants);
        ListOfMine.Add(are);
        ListOfMine.Add(dancing);
        ListOfMine.Add(get);
        ListOfMine.Add(back);
         actual = ListOfMine.Capacity;
        //Assert
        Assert.AreEqual(expected, actual);
       }
    //Capacity at Four
    [TestMethod]
    public void AddAdditionalValueCapacityFour()
     {       
    //arange
    CustomList<String> ListOfMine = new CustomList<string>();
    string ValueZero = "something";
    int actual;
    int expected = 4;
    //act
    ListOfMine.Add(ValueZero);
    actual = ListOfMine.Capacity;
    //assert
    Assert.AreEqual(expected, actual);
             }
        
   }
}