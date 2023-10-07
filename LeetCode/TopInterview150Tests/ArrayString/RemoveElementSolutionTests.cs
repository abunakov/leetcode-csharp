using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopInterview150.ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.ArrayString.Tests
{
    [TestClass()]
    public class RemoveElementSolutionTests
    {
        [TestMethod()]
        public void RemoveElement_Test1()
        {
            int[] nums = { 3, 2, 2, 3 }; // Input array
            int val = 3; // Value to remove
            int[] expectedNums = { 2, 2 }; // The expected answer with correct length.
                                        // It is sorted with no values equaling val.
            
            var solution = new RemoveElementSolution();
            int k = solution.RemoveElement(nums, val); // Calls your implementation

            Assert.AreEqual(expectedNums.Length, k);

            //Array.Sort(nums, 0, k); // Sort the first k elements of nums
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i]);
            }
        }

        [TestMethod()]
        public void RemoveElement_Test2()
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 }; // Input array
            int val = 2; // Value to remove
            int[] expectedNums = { 0, 1, 4, 0, 3 }; // The expected answer with correct length.
                                           // It is sorted with no values equaling val.

            var solution = new RemoveElementSolution();
            int k = solution.RemoveElement(nums, val); // Calls your implementation

            Assert.AreEqual(expectedNums.Length, k);

            //Array.Sort(nums, 0, k); // Sort the first k elements of nums
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i]);
            }
        }
    }
}