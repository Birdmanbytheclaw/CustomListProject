﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProj;

namespace CustomListClassTest
{
    [TestClass]
    public class UnitTest1
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
        public void AddMethod_SecindThingAdded_IndexOne()
        {
            //arrange
            CustomList<int> ListOfMine = new CustomList<int>();
            int actual;
            int expected = 2;

            //act
            ListOfMine.Add(7);
            ListOfMine.Add(2);
            actual = ListOfMine[1];

            //assert
            Assert.AreEqual(expected, actual);
        }
        public void ListIndexNumberCount()
        {
            //Test Count
            //Arrange
            CustomList<int> ListOfMine = new CustomList<int>();
            int actual;
            int excpected = ListOfMine.Count;

            //ActL
            ListOfMine.Add(7);
            ListOfMine.Add(2);
            ListOfMine.Add(3);
            actual = ListOfMine[];
            //Assertf
            Assert.AreEqual(expected, actual);
        }
        //Make sure 0 does not get overwritten
        {
        //Arrange
        CustomList<int> ListOfMine = new CustomList<int>();
        int actual;
        int expected;
        //Act

        //Assert
        Assert.AreEqual(expected, actual);
      
        }
    //test adding the same thing twice and both exist
    {
    //Arrange

    //Act

    //Assert
    Assert.AreEqual(expected, actual);
      }
        //test capacity Growth after 5 are added
       { 
        //Arrange

        //Act

        //Assert
        Assert.AreEqual(expected, actual);
       }
      
        

        
    }
}