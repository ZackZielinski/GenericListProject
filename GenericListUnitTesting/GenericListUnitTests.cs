using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericListUnitTesting
{
    [TestClass]
    public class GenericListUnitTests
    {
        [TestMethod]
        public void DoesTheArrayHaveValues()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();

            //Act
            CustomList.Count();

            //Assert
        }
        [TestMethod]
        public void DoesTheArrayAddValues()
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
        public void DoesListStoreString()
        {
            //Arrange
            GenericList<string> CustomList = new GenericList<string>();
            string ExpectedResult = " ";
            string ActualResult;

            //Act

            ActualResult = CustomList[0];

            //Assert
            Assert.IsFalse(ExpectedResult == ActualResult);

        }
        /*
        [TestMethod]
        public void DoestheListRemoveValues()
        {
            //Arrange
            GenericList<int> CustomList = new GenericList<int>();
            int ExpectedResult = 20;
            //Act
            CustomList.Add(ExpectedResult);
            CustomList.Remove(ExpectedResult);
            

            //Assert
            Assert.AreNotEqual(ExpectedResult, CustomList[0]);
            
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

            NumberList.Zip(WordList, (first, second) => first + " " + second);
            
            //Assert
            Assert.IsTrue(NumberList[6] == 6);
        } */

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

    }
}
