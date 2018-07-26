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
            
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> cmList1 = new CustomList<int>();
            CustomList<int> cmList2 = new CustomList<int>();
            int expected = 1;
            int actual;
           
            cmList1.Add(1);
            cmList2.Add(2);

            customList = cmList1 + cmList2; // { 1, 2 }
            actual = customList[0];

            Assert.AreEqual(expected, actual);



        }
        public void Iterating_Array()
        {

        }
    }
}

