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
            string FourthWord = "Anatomy";
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
            string WordOne = "Tragedy";
            string WordTwo = "Rhapsody";
            string WordThree = "Gallantry";
            string WordFour = "Travesty";
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
            string WordFive = "Gallantry";
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
        public void RemoveMultipleThenmoveLastItemToindeX2()
        {//Arrange
            CustomList<string> ListOfMine = new CustomList<string>();
            string WordOne = "Casually";
            string WordTwo = "Fallacy";
            string WordThree = "Passably";
            string WordFour = "Tactfully";
            string WordFive = "Gadgetry";
            string expected = "Gadgetry";
            string actual;
            //Act
            ListOfMine.Add(WordTwo);
            ListOfMine.Add(WordOne);
            ListOfMine.Add(WordThree);
            ListOfMine.Add(WordFour);
            ListOfMine.Add(WordFive);
            ListOfMine.Remove(WordOne);
            ListOfMine.Remove(WordFour);
            actual = ListOfMine[2];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveOneThingButAddThree()
        {

            //Assert
            Assert.AreEqual(expected, actual);
            CustomList<string> ListOfMine = new CustomList<string>();
            string WordOne = "Analogy";
            string WordTwo = "Academy";
            string WordThree = "Formality";
            string WordFour = "Neutrality";
            string WordFive = "Fatality";
            string WordSix = "Audacity";
            string expected = "Audacity";
            string actual;
            //Act
            ListOfMine.Add(WordTwo);
            ListOfMine.Add(WordOne);
            ListOfMine.Remove(WordOne);
            ListOfMine.Add(WordThree);
            ListOfMine.Add(WordFour);
            ListOfMine.Add(WordFive);
            ListOfMine.Add(WordSix);

            actual = ListOfMine[4];
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIfListIsOutOfIndexAndDisplayIt()
        {

            //Arrange
            CustomList<int> CheckList = new CustomList<int>;
            int actual;
            //Act
            actual = CheckList[2];
            

        }
        
      
    }
}
