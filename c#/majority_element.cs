/*
Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
*/

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int midPoint = (nums.Length) / 2;

        for (int i = 0; i < nums.Length; i++)
        {
            int cursor = nums[i];
            int cursorCount = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == cursor)
                {
                    cursorCount++;
                }

                if (cursorCount > midPoint)
                {
                    return cursor;
                }
            }
        }

        return 0;
    }
}

/*
Alternative solution using Bayre moore
*/

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        int candidate = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }

            /*
            if (num == candidate) {
                count++;
            } else {
                count--;
            }
            */

            count += (candidate == num) ? 1 : -1;
        }

        return candidate;
    }
}