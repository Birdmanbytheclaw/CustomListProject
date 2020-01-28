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
        public void RemoveTheFirstInstanceOfAValue_SecondInstanceStaysAndShiftsDown()
        {
            //Arrange
            CustomList<string> ListOfMine = new CustomList<string>();
            string FirstWord = "Calamity";
            string SecondWord = "Profanity";
            string ThirdWord = "Humanity";
            string FourthWord = "anatomy";
            string expected = FirstWord;
            string actual;
            //Act
            ListOfMine.Add(SecondWord);
            ListOfMine.Add(FirstWord);
            ListOfMine.Add(ThirdWord);
            ListOfMine.Add(FirstWord);
            ListOfMine.Add(FourthWord);
            ListOfMine.Remove(FirstWord);
            actual = ListOfMine[2];
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void RemoveFirstInstanceThenDecreaseCountByOne()
        {
            //Arrange
            CustomList<string> ListofMine = new CustomList<string>();
            string WordOne = "tragedy";
            string WordTwo = "Rhapsody";
            string WordThree = "Gallantry";
            string WordFour = "travesty";
            int expected = 4;
            int actual;
            //Act
            ListofMine.Add(WordTwo);
            ListofMine.Add(WordOne);
            ListofMine.Add(WordThree);
            ListofMine.Add(WordOne);
            ListofMine.Add(WordFour);
            ListofMine.Remove(WordOne);
            actual = ListofMine.Count;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void RemoveMultipleFromCountDrecresingByTwo()
        {
            //Arrange
            CustomList<string> ListOfMine = new CustomList<string>();
            string WordOne = "Naturally";
            string WotdTwo = "Tacfully";
            string WordThree = "Callously";
            string WordFour = "Valiantly";
            string WordFive = "gallantry";
            int expected = 3;
            int actual;
            //Act
            ListOfMine.Add(WotdTwo);
            ListOfMine.Add(WordOne);
            ListOfMine.Add(WordThree);
            ListOfMine.Add(WordFour);
            ListOfMine.Add(WordFive);
            ListOfMine.Remove(WordOne);
            ListOfMine.Remove(WordFive);
            actual = ListOfMine.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveMultipleThenmoveLastItemToindev2()
        { 
        
        }

        //Arrange

        //Act

        //Assert
        Assert.AreEqual(expected, actual);
      
    }
}
