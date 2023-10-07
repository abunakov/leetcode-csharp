using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.ArrayString
{
    public class RemoveElementSolution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            int p1 = 0;
            int p2 = nums.Length - 1;

            while (p1 <= p2)
            {
                if (nums[p2] == val)
                {
                    p2--;
                    continue;
                }
                if (nums[p1] == val)
                {
                    nums[p1] = nums[p2];
                    p2--;
                }
                p1++;
                k++;
            }

            return k;
        }
    }
}
