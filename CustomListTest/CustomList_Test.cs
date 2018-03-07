using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gallium_CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomList_Test
    {
        private int expected;

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
            int actual;
           
            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);

            actual = customList.Remove();
            //Assert
            Assert.AreEqual(expected, actual);

        }
       [TestMethod]
       public void Array_To_String()
        {
            CustomList<int> customList = new CustomList<int>();
            int actual;

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);

            actual = customList.ToString(2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Overloading_Plus_Operator()
        {
            int actual;
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList1 = new CustomList<int>(); 
            CustomList<int> customList2 = new CustomList<int>();

            customList1.Add(1);
            customList2.Add(2);

        

        }
         public void Iterating_Array()
        {

        }

}

