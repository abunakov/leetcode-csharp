using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopInterview150.ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150Tests.ArrayString
{
    [TestClass()]
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [TestMethod()]
        public void RemoveDuplicates_Example1()
        {
            int[] nums = { 1, 1, 2 }; // Input array
            int[] expectedNums = { 1, 2 }; // The expected answer with correct length

            var solution = new RemoveDuplicatesFromSortedArraySolution();
            int k = solution.RemoveDuplicates(nums); // Calls your implementation

            Assert.IsTrue( k == expectedNums.Length);
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual<int>(expectedNums[i], nums[i]);
            }
        }

        [TestMethod]
        public void RemoveDuplicates_Example2()
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }; // Input array
            int[] expectedNums = { 0, 1, 2, 3, 4 }; // The expected answer with correct length

            var solution = new RemoveDuplicatesFromSortedArraySolution();
            int k = solution.RemoveDuplicates(nums); // Calls your implementation

            Assert.IsTrue(k == expectedNums.Length);
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual<int>(expectedNums[i], nums[i]);
            }
        }
    }
}
