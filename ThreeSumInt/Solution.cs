using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSumInt
{
    public class Solution
    {
        // statistics
        // Runtime 72ms - Beats 92.93%
        // Memory 42.04MB - Beats 69.37%

        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int closestSum = 1000000;
            int runningTotal = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int leftIndex = i + 1;
                int rightIndex = nums.Length - 1;

                while (leftIndex < rightIndex)
                {
                    runningTotal = nums[i] + nums[leftIndex] + nums[rightIndex];
                    if(runningTotal == target)
                    {
                        return target;
                    }
                    else
                    {
                        if(Math.Abs(runningTotal - target) < Math.Abs(closestSum - target))
                        {
                            closestSum = runningTotal;
                        }
                    }

                    if(runningTotal < target)
                    {
                        leftIndex++;
                    }
                    else
                    {
                        rightIndex--;
                    }
                }
            }
            return closestSum;
        }
    }
}
