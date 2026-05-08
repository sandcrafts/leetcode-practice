/*
1. Two Sum

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?

*/
public class Solution
{
    public static readonly int[] InputNumbers = new int[] { 3, 2, 4 };
    public static readonly int Target = 9;

    public int[] Solve(int[] nums, int target)
    {
        Dictionary<int, int> holder = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            if (holder.TryGetValue(diff, out int index))
            {
                return [i, index];
            }

            holder[nums[i]] = i;
        }

        return [];
    }

    public int[] SolveI(int[] nums, int target)
    {
        Dictionary<int, int> holder = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            holder[diff] = i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (holder.TryGetValue(nums[i], out int index) && i != index)
            {
                return [i, index];
            }

        }

        return [];
    }

    public int[] SolveII(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return [];
    }
}

