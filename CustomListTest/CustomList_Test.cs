﻿using System;
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
        [TestMethod]
        public void Zip_Numberlist_123456()
        {
            int expected = 1;
            CustomList<int> cmList1 = new CustomList<int>() { 1, 3, 5, 7 };
            CustomList<int> cmList2 = new CustomList<int>() { 2, 4, 6, 8 };
            cmList1.Zip(cmList2);

            Assert.AreEqual(expected, cmList1[6]);
        } 
        [TestMethod]
        public void Remove_Multiple_Numbers()
        {
            int expected = 3;
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

            list.Remove(1);
            list.Remove(2);
            list.Remove(4);
            list.Remove(5);
            list.Remove(6);

            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Add_Multiple_Numbers()
        {
            int expected = 8;
            CustomList<int> list = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            list.Add(11);

            Assert.AreEqual(expected, list[8]);
        }
    }
}

