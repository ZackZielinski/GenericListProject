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
            int ExpectedResult = 35;
            int? ActualResult = null;


            //Act
            CustomList.Add(ExpectedResult);

            ActualResult = CustomList[0];

            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        
        
        [TestMethod]
        public void DoesTheArrayAddFourValues()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int? ExpectedResult = 534;
            int? ActualResult = null;


            //Act
            CustomList.Add(35);
            CustomList.Add(23);
            CustomList.Add(375);
            CustomList.Add(534);

            ActualResult = CustomList[3];

            //Assert
            Assert.IsTrue(ExpectedResult == ActualResult);
        }
        
        [TestMethod]
        public void DoesTheArrayAddTwelveValues()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int ExpectedResult = 12;
            int? ActualResult = null;


            //Act
            CustomList.Add(1);
            CustomList.Add(2);
            CustomList.Add(3);
            CustomList.Add(4);
            CustomList.Add(5);
            CustomList.Add(6);
            CustomList.Add(7);
            CustomList.Add(8);
            CustomList.Add(9);
            CustomList.Add(10);
            CustomList.Add(11);
            CustomList.Add(12);

            ActualResult = CustomList[11];

            //Assert
            Assert.IsTrue(ExpectedResult == ActualResult);
        }
       
        [TestMethod]
        public void DoesArrayCountEmptyArray()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int ExpectedResults = 0;
            int ActualResult;
            //Act
            ActualResult = CustomList.Count;

            //Assert
            Assert.AreEqual(ExpectedResults, ActualResult);
        }

        
         [TestMethod]
        public void DoesArrayCountValuesInTheArray()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int ExpectedResults = 3;
            int ActualResult;

            //Act
            CustomList.Add(1);
            CustomList.Add(2);
            CustomList.Add(3);

            ActualResult = CustomList.Count;

            //Assert
            Assert.AreEqual(ExpectedResults, ActualResult);
        }

       
        [TestMethod]
        public void DoValuesCountProperlyAfterOneRemoval()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int ExpectedResults = 4;
            int ActualResult;
            //Act
            CustomList.Add(1);
            CustomList.Add(2);
            CustomList.Add(3);
            CustomList.Add(4);
            CustomList.Add(5);
            CustomList.Remove(3);

            ActualResult = CustomList.Count;

            //Assert
            Assert.AreEqual(ExpectedResults, ActualResult);
        }

        
        [TestMethod]
        public void DoValuesCountProperlyAfterMultipleRemovals()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int ExpectedResults = 2;
            //Act
            CustomList.Add(1);
            CustomList.Add(2);
            CustomList.Add(1);
            CustomList.Add(4);
            CustomList.Add(5);
            CustomList.Remove(1);
            CustomList.Remove(5);

            //Assert
            Assert.AreEqual(ExpectedResults, CustomList.Count);
        }

       
        [TestMethod]
        public void ConvertListToAString()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            string ExpectedResult = "357";
            string ActualResult;

            //Act
            CustomList.Add(3);
            CustomList.Add(5);
            CustomList.Add(7);

            ActualResult = CustomList.AsString();

            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);

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
            Assert.AreEqual(ExpectedResult, CustomList[0]);
            
        }

        
        [TestMethod]
        public void DoestheListRemoveTwoValues()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int ExpectedResult = 2;
            //Act
            CustomList.Add(1);
            CustomList.Add(ExpectedResult);
            CustomList.Add(3);
            CustomList.Remove(1);
            CustomList.Remove(3);

            //Assert
            Assert.AreEqual(ExpectedResult, CustomList[0]);

        }
        
             [TestMethod]
        public void DoestheListRemoveSixValues()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            GenericList<int> ExpectedResult = new GenericList<int>();
            
            //Act
            CustomList.Add(1);
            CustomList.Add(2);
            CustomList.Add(3);
            CustomList.Add(4);
            CustomList.Add(5);
            CustomList.Add(6);
            CustomList.Add(7);
            CustomList.Add(8);
            CustomList.Add(9);

            ExpectedResult.Add(7);
            ExpectedResult.Add(8);
            ExpectedResult.Add(9);

            CustomList.Remove(1);
            CustomList.Remove(2);
            CustomList.Remove(3);
            CustomList.Remove(4);
            CustomList.Remove(5);
            CustomList.Remove(6);

            //Assert
            Assert.AreEqual(ExpectedResult[1], CustomList[1]);

        }
        
        
        [TestMethod]
        public void DoCustomArraysZipIntegers()
        {
            //Arrange
            GenericList<int> OddNumberList = new GenericList<int>();
            GenericList<int> EvenNumberList = new GenericList<int>();
            GenericList<int> ZippedList = new GenericList<int>();

            int ExpectedResult = 6;

            //Act
            OddNumberList.Add(1);
            OddNumberList.Add(3);
            OddNumberList.Add(5);

            EvenNumberList.Add(2);
            EvenNumberList.Add(4);
            EvenNumberList.Add(6);

            ZippedList.Zip(OddNumberList,EvenNumberList);
            
            //Assert
            Assert.AreEqual(ExpectedResult, ZippedList[5]);
        }
        
        [TestMethod]
        public void DoCustomArraysZipStrings()
        {
            //Arrange
            GenericList<string> NumberList = new GenericList<string>();
            GenericList<string> WordList = new GenericList<string>();
            GenericList<string> ResultList = new GenericList<string>();

            //Act
            NumberList.Add("1");
            NumberList.Add("2");
            NumberList.Add("3");

            WordList.Add("one");
            WordList.Add("two");
            WordList.Add("three");

            ResultList.Zip(NumberList, WordList);

            //Assert
            Assert.AreEqual(WordList[2], ResultList[6]);
        }
  

        [TestMethod]
        public void DoCustomArraysZipAZippedList()
        {
            //Arrange
            GenericList<int> OddNumberList = new GenericList<int>();
            GenericList<int> EvenNumberList = new GenericList<int>();
            GenericList<int> CounterList = new GenericList<int>();
            GenericList<int> CustomList =  new GenericList<int>();
            GenericList<int> ResultList = new GenericList<int>();

            //Act
            OddNumberList.Add(1);
            OddNumberList.Add(3);
            OddNumberList.Add(5);

            EvenNumberList.Add(2);
            EvenNumberList.Add(4);
            EvenNumberList.Add(6);

            CounterList.Add(7);
            CounterList.Add(8);
            CounterList.Add(9);
            CounterList.Add(10);
            CounterList.Add(11);
            CounterList.Add(12);

            CustomList.Zip(OddNumberList, EvenNumberList);

            ResultList.Zip(CustomList, CounterList);

            //Assert
            Assert.AreEqual(CounterList[5], ResultList[11]);
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
            GenericList<int> CustomList = new GenericList<int>();
            GenericList<int> ExpectedResult = new GenericList<int>();
            GenericList<int> ActualResult = new GenericList<int>();

            //Act
            ExpectedResult.Add(34);
            ExpectedResult.Add(45);
            ExpectedResult.Add(34);
            ExpectedResult.Add(45);

            CustomList.Add(34);
            CustomList.Add(45);

            ActualResult = CustomList + CustomList;

            //Assert
            Assert.AreEqual(ExpectedResult[3], ActualResult[3]);

        }


        [TestMethod]
        public void AddingAListWithinAnAddedList()
        {
            //Arrange
            GenericList<int> EvenList = new GenericList<int>();
            GenericList<int> OddList = new GenericList<int>();
            GenericList<int> CustomList = new GenericList<int>();
            GenericList<int> ExpectedResult = new GenericList<int>();
            GenericList<int> ActualResult = new GenericList<int>();
            GenericList<int> NumberedList = new GenericList<int>();

            //Act
            ExpectedResult.Add(1);
            ExpectedResult.Add(3);
            ExpectedResult.Add(2);
            ExpectedResult.Add(4);
            ExpectedResult.Add(5);
            ExpectedResult.Add(6);

            OddList.Add(1);
            OddList.Add(3);

            EvenList.Add(2);
            EvenList.Add(4);

            CustomList.Add(5);
            CustomList.Add(6);

            NumberedList = OddList + EvenList;

            ActualResult = NumberedList + CustomList;

            //Assert
            Assert.AreEqual(ExpectedResult[5], ActualResult[5]);

        }

        
        [TestMethod]
        public void OverloadingMinusOperator()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            GenericList<int> ExpectedResult = new GenericList<int>();
            GenericList<int> DuplicateList = new GenericList<int>();
            GenericList<int> ActualResult = new GenericList<int>();

            //Act
            ExpectedResult.Add(1);
            ExpectedResult.Add(2);

            CustomList.Add(1);
            CustomList.Add(2);
            CustomList.Add(3);
            CustomList.Add(4);

            DuplicateList.Add(3);
            DuplicateList.Add(4);

            ActualResult = CustomList - DuplicateList;

            //Assert
            Assert.AreEqual(ExpectedResult[1], ActualResult[1]);

        }

        
        [TestMethod]
        public void UsingMinusOverloadTwice()
        {
            //Arrange
            GenericList<int> NumberList = new GenericList<int>();
            GenericList<int> ExpectedResult = new GenericList<int>();
            GenericList<int> CustomList = new GenericList<int>();
            GenericList<int> DuplicateList = new GenericList<int>();
            GenericList<int> SubtractedList = new GenericList<int>();
            GenericList<int> ActualResult = new GenericList<int>();

            //Act
            ExpectedResult.Add(1);
            ExpectedResult.Add(2);


            NumberList.Add(1);
            NumberList.Add(2);
            NumberList.Add(3);
            NumberList.Add(4);
            NumberList.Add(5);
            NumberList.Add(6);


            CustomList.Add(3);
            CustomList.Add(4);

            DuplicateList.Add(5);
            DuplicateList.Add(6);

            SubtractedList = NumberList - CustomList;

            ActualResult = SubtractedList - DuplicateList;

            //Assert
            Assert.AreEqual(ExpectedResult[1], ActualResult[1]);

        }
        


    }
}
