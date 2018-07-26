using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gallium_CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomList_Test
    {
        //private int expected;
        //private object actual;

        [TestMethod]
        public void AddValueIn_Array_CreateNewArray()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            //Act
            customList.Add(0);
            int expected = 0;

            //Assert
            Assert.AreEqual(expected, customList[0]);

        }

        [TestMethod]
        public void AddValueIn_Array_IncreaseCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int actual;

            //Act
            customList.Add(0);
            int expected = 1;
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_Array_Decrease_Count()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 3;
            int actual;

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);

            customList.Remove(2);

            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Array_To_String()
        {
            CustomList<int> customList = new CustomList<int>();
            string expected = "1, 2, 3, 4";
            string actual;

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);

            actual = customList.ToString();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Overloading_Plus_Operator()
        {
            
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            CustomList<int> cmList1 = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> cmList2 = new CustomList<int>() { 5, 6, 7, 8 };
            CustomList<int> result = new CustomList<int>();

            result = cmList1 + cmList2;

            Assert.AreEqual(expected[4], result[4]);

        }
        [TestMethod]
        public void Overloading_Minus_Operator()
        {
            CustomList<int> expected = new CustomList<int>() { 2, 3};
            CustomList<int> cmList1 = new CustomList<int>() { 1, 2, 3};
            CustomList<int> cmList2 = new CustomList<int>() { 1 };
            CustomList<int> result = new CustomList<int>();

            result = cmList1 - cmList2;

            Assert.AreEqual(expected[0], result[0]);

        }
        [TestMethod]
        public void Add_Number_4()
        {
            int expected = 4;
            CustomList<int> list = new CustomList<int>();

            list.Add(4);

            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Remove_Number_4()
        {
            int expected = 0;
            CustomList<int> list = new CustomList<int>() { 4 };

            list.Remove(list[0]);

            Assert.AreEqual(expected, list.Count);
        } 
    }
}

