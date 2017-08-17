using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericListUnitTesting
{
    [TestClass]
    public class GenericListUnitTests
    {

        [TestMethod]
        public void DoesTheArrayAddOneValue()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int? ExpectedResult = null;
            int? ActualResult = null;


            //Act
            CustomList.Add(35);

            ActualResult = CustomList[0];

            //Assert
            Assert.IsTrue(ExpectedResult != ActualResult);
        }

        [TestMethod]
        public void DoesTheArrayAddMultipleValues()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int? ExpectedResult = null;
            int? ActualResult = null;


            //Act
            CustomList.Add(35);
            CustomList.Add(23);
            CustomList.Add(375);
            CustomList.Add(534);

            ActualResult = CustomList[3];

            //Assert
            Assert.IsTrue(ExpectedResult != ActualResult);
        }

        [TestMethod]
        public void DoesListAddAnotherList()
        {
            //Arrange
            GenericList<int> NumberList = new GenericList<int>();
            GenericList<int> CustomList = new GenericList<int>();
            int ExpectedResult = 21;

            //Act
            NumberList.Add(46);
            NumberList.Add(27);
            NumberList.Add(ExpectedResult);
            CustomList.AddRange(NumberList);

            //Assert
            Assert.IsTrue(ExpectedResult == CustomList[2]);
        }

        [TestMethod]
        public void DoesArrayCountValues()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int ExpectedResults = 1;
            //Act
            CustomList.Count();

            //Assert
            Assert.AreEqual(ExpectedResults, CustomList.Count());
        }

        [TestMethod]
        public void HowManyValuesCounted()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int ExpectedResults = 3;
            //Act
            CustomList.Add(57);
            CustomList.Add(34);
            CustomList.Add(925);

            //Assert
            Assert.AreEqual(ExpectedResults, CustomList.Count());
        }

        [TestMethod]
        public void DoValuesCountProperAfterRemoval()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int ExpectedResults = 4;
            //Act
            CustomList.Add(57);
            CustomList.Add(34);
            CustomList.Add(666);
            CustomList.Add(4213);
            CustomList.Add(4532);
            CustomList.Remove(57);

            //Assert
            Assert.AreEqual(ExpectedResults, CustomList.Count());
        }

        [TestMethod]
        public void ListConvertToString()
        {
            //Arrange
            GenericList<string> CustomList = new GenericList<string>();
            string ExpectedResult = "357";
            string ActualResult;

            //Act
            CustomList.Add(357);

            ActualResult = CustomList[0].ToString;

            //Assert
            Assert.IsTrue(ExpectedResult == ActualResult);

        }

        [TestMethod]
        public void DoesListConvertMultipleValuesToString()
        {
            //Arrange
            GenericList<string> CustomList = new GenericList<string>();
            string ExpectedResult = "357 , 43524, 746";
            string ActualResult;

            //Act
            CustomList.Add(357);
            CustomList.Add(43524);
            CustomList.Add(746);

            ActualResult = CustomList.ToString;

            //Assert
            Assert.IsTrue(ExpectedResult == ActualResult);

        }


        [TestMethod]
        public void DoestheListRemoveOneValue()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int number = 20;
            int ExpectedResult = 57;
            //Act
            CustomList.Add(number);
            CustomList.Add(ExpectedResult);

            CustomList.Remove(number);
            

            //Assert
            Assert.AreEqual(CustomList[0], ExpectedResult);
            
        }

        [TestMethod]
        public void DoestheListRemoveMultipleValues()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int ExpectedResult = 357;
            //Act
            CustomList.Add(456);
            CustomList.Add(795);
            CustomList.Add(ExpectedResult);
            CustomList.Remove(456);
            CustomList.Remove(795);

            //Assert
            Assert.AreEqual(ExpectedResult, CustomList[0]);

        }

        [TestMethod]
        public void DoCustomArraysZip()
        {
            //Arrange
            GenericList<int> NumberList = new GenericList<int>();
            GenericList<int> WordList = new GenericList<int>();
            

            //Act
            NumberList.Add(1);
            NumberList.Add(2);
            NumberList.Add(3);

            WordList.Add(2);
            WordList.Add(4);
            WordList.Add(6);

            NumberList.Zip(WordList, (first, second) => first + " , " + second);
            
            //Assert
            Assert.IsTrue(NumberList[6] == 6);
        } 

        [TestMethod]
        public void DoestheListSwapTwoValues()
        {
            //Arrange
            GenericSwap<int> NumberList = new GenericSwap<int>();
            int FirstNumberToSwap = 13;
            int SecondNumberToSwap = 29;
            int NewFirstNumber = 29;
            int NewSecondNumber = 13;

            //Act
            NumberList.SwapMethod(ref FirstNumberToSwap, ref SecondNumberToSwap);

            //Assert
            Assert.IsTrue(FirstNumberToSwap == NewFirstNumber && SecondNumberToSwap == NewSecondNumber);
        }

        [TestMethod]
        public void OverloadingPlusOperator()
        {
            //Arrange
            GenericList<int> CustomList = GenericList<int>();
            int ExpectedResult = 79;
            int ActualResult;

            //Act
            CustomList.Add(34);
            CustomList.Add(45);

            ActualResult = CustomList[0] + CustomList[1];
            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);


        }



    }
}
