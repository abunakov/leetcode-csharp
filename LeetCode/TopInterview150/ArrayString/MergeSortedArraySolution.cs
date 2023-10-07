using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.ArrayString
{
    public class MergeSortedArraySolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // point to the last element of each array
            int pend = m + n;
            m--;
            n--;

            while (n >= 0)
            {
                --pend;
                if (m >= 0)
                {
                    if (nums1[m] <= nums2[n])
                    {
                        nums1[pend] = nums2[n--];
                    }
                    else // (nums1[m] > nums2[n])
                    {
                        nums1[pend] = nums1[m--];
                    }
                }
                else
                {
                    nums1[pend] = nums2[n--];
                }
            }
        }
    }
}
