using System;
using CustomLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLinkedListTest
{
    [TestClass]
    public class CustomLinkedListTest
    {
        DynamicList<int> dynamicList;

        [TestInitialize]
        public void TestInitialize()
        {
            this.dynamicList = new DynamicList<int>();
        }

        [TestMethod]
        public void Count_CountOfDynamicList_ShouldCorrectCount()
        {
            this.dynamicList.Add(2);
            this.dynamicList.Add(3);
            this.dynamicList.Add(0);

            Assert.AreEqual(3, dynamicList.Count, "Count is not correct.");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void Indexator_GetInRange_ShouldThrow()
        {
            this.dynamicList.Add(2);
            int number = this.dynamicList[2];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexator_SetInRange_ShouldThrow()
        {
            this.dynamicList.Add(2);
            this.dynamicList[2] = 6;
        }

        [TestMethod]
        public void Add_FullList_ShouldResizeCorrectly()
        {
            this.dynamicList.Add(6);
            this.dynamicList.Add(6);
            this.dynamicList.Add(6);

            Assert.AreEqual(3, dynamicList.Count, "Method Add is not correct.");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void RemoveAt_IndexInRange_ShouldThrow()
        {
            this.dynamicList.Add(0);
            this.dynamicList.RemoveAt(2);
        }

        [TestMethod]
        public void RemoveAt_RemoveElementOfIndex_ShouldMoveOtherElements()
        {
            this.dynamicList.Add(0);
            this.dynamicList.Add(1);
            this.dynamicList.Add(2);
            this.dynamicList.Add(3);

            this.dynamicList.RemoveAt(1);
            Assert.AreEqual(2, dynamicList[1], "This element is wrong.");
        }

        [TestMethod]
        public void Remove_RemoveThisItem_ShouldRemoveEqualElementsLikeThisItem()
        {
            this.dynamicList.Add(9);
            this.dynamicList.Add(9);
            this.dynamicList.Add(0);
            this.dynamicList.Add(9);
            this.dynamicList.Add(9);

            dynamicList.Remove(9);
            Assert.AreEqual(4, dynamicList.Count, "This count is wrong, should be less");
        }

        [TestMethod]
        public void Remove_RemoveItem_ShouldReturnSpecificValueIfItemDoesNotExist()
        {
            this.dynamicList.Add(9);
            this.dynamicList.Add(9);
            this.dynamicList.Add(0);
            this.dynamicList.Add(9);
            this.dynamicList.Add(9);

            Assert.AreEqual(-1, dynamicList.Remove(3), "This is not correct value, should be -1");
        }

        [TestMethod]
        public void IndexOf_SearchIndexOfElement_ShouldReturnIndexOfElement()
        {
            this.dynamicList.Add(9);
            this.dynamicList.Add(0);
            this.dynamicList.Add(9);

            Assert.AreEqual(1, dynamicList.IndexOf(0), "This is wrong value.");
        }

        [TestMethod]
        public void IndexOf_SearchIndexOfElement_ShouldReturnSpecificValueIfDoesNotThisElement()
        {
            this.dynamicList.Add(9);
            this.dynamicList.Add(0);
            this.dynamicList.Add(9);

            Assert.AreEqual(-1, dynamicList.IndexOf(3), "This is not correct value, must be -1.");
        }

        [TestMethod]
        public void Contains_ReturnTrueForContainsValue_ShouldReturnTrue()
        {
            this.dynamicList.Add(78);

            Assert.AreEqual(true, dynamicList.Contains(78), "Bool value is wrong.");
        }
    }
}
