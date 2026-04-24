/*
209. Minimum Size Subarray Sum

Given an array of positive integers nums and a positive integer target, return the minimal length of a subarray whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.

 

Example 1:

Input: target = 7, nums = [2,3,1,2,4,3]
Output: 2
Explanation: The subarray [4,3] has the minimal length under the problem constraint.
Example 2:

Input: target = 4, nums = [1,4,4]
Output: 1
Example 3:

Input: target = 11, nums = [1,1,1,1,1,1,1,1]
Output: 0
 

Constraints:

1 <= target <= 109
1 <= nums.length <= 105
1 <= nums[i] <= 104
 

Follow up: If you have figured out the O(n) solution, try coding another solution of which the time complexity is O(n log(n)).

*/
public class Solution {
    public static readonly int[] Nums = new int[] {2,3,1,2,4,3};
    public static readonly int Target = 7;

    // first go: correct but time limit exceeded
    public int Solve(int target, int[] nums)
    {
        int min = nums.Length + 1;

        for (int i = 0; i < nums.Length; i++) {
            int left = i;
            int sum = 0;
            int count = 0;

            while (left >= 0) {
                sum += nums[left];
                count++;
                if (sum >= target) {
                    if (count < min) {
                        min = count;
                    }
                    break;
                }

                left --;
            }
        }

        if (min <= nums.Length) {
            return min;
        } else {
            return 0;
        }
    }
}

