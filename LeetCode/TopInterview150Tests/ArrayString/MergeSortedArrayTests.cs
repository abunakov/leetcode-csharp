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
    public class MergeSortedArrayTests
    {
        [TestMethod()]
        public void Merge_Test1()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            const int m = 3;
            int[] nums2 = { 2, 5, 6 };
            const int n = 3;
            int[] expected = { 1, 2, 2, 3, 5, 6 };

            var solution = new MergeSortedArraySolution();
            solution.Merge(nums1, m, nums2, n);

            Assert.IsTrue(Enumerable.SequenceEqual(expected, nums1));
        }

        [TestMethod()]
        public void Merge_Test2()
        {
            int[] nums1 = { 1 };
            const int m = 1;
            int[] nums2 = Array.Empty<int>();
            const int n = 0;
            int[] expected = { 1 };

            var solution = new MergeSortedArraySolution();
            solution.Merge(nums1, m, nums2, n);

            Assert.IsTrue(Enumerable.SequenceEqual(expected, nums1));
        }

        [TestMethod()]
        public void Merge_Test3()
        {
            int[] nums1 = { 0 };
            const int m = 0;
            int[] nums2 = { 1 };
            const int n = 1;
            int[] expected = { 1 };

            var solution = new MergeSortedArraySolution();
            solution.Merge(nums1, m, nums2, n);

            Assert.IsTrue(Enumerable.SequenceEqual(expected, nums1));
        }
    }
}