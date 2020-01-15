using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
namespace Algorithm_Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void SelectionSort()
        {
            //Arrange
            int[] arr = { 1, 3, 5, 2, 10, 0 };
            string expected = "0123510";

            //Act
            string actual = Selection.SelectionSort(arr);
            //Asert
            Assert.AreEqual(expected, actual, "The Array was\'nt sorted successfully");

        }

        [TestMethod]
        public void BubbleSort()
        {
            // Arrange
            int[] arr = { 1, 3, 5, 2, 10, 0 };
            string expected = "0123510";

            //Act
            string actual = Bubble.BubbleSort(arr);
            //Asert
            Assert.AreEqual(expected, actual, "The Array was\'nt sorted successfully");
        }

        [TestMethod]
        public void BinarySearch()
        {
            //Arrange
            int[] newArray = { 8, 2, 7, 4, 5, 66, 9 };
            int expected = 5;
            //Act
            int actual = Algorithm.BinarySearch.BinarySearchDisplay(newArray, 9);

            //Assert
            Assert.AreEqual(expected, actual, "The Item was\'nt found");
        }
    }
}
