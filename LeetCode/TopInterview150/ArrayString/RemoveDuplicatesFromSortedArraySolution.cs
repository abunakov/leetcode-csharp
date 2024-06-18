using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.ArrayString
{
    public class RemoveDuplicatesFromSortedArraySolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;

            int k = 1;
            int p1 = 0;
            int p2 = 1;
            while (p2 < nums.Length)
            {
                if (nums[p1] == nums[p2])
                {
                    p2++;
                    continue;
                }
                nums[++p1] = nums[p2++];
                k++;
            }
            return k;
        }
    }
}
