/*

42. Trapping Rain Water

Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

Example 1:

Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.
Example 2:

Input: height = [4,2,0,3,2,5]
Output: 9
 

Constraints:

n == height.length
1 <= n <= 2 * 104
0 <= height[i] <= 105

*/
public class Solution
{
    public static readonly int[] Input = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

    public int Solve(int[] height)
    {
        int left = 0, right = height.Length - 1;
        int leftMax = 0, rightMax = 0;
        int total = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= leftMax)
                {
                    leftMax = height[left];
                }
                else
                {
                    total += leftMax - height[left];
                }
                left++;
            }
            else
            {
                if (height[right] >= rightMax)
                {
                    rightMax = height[right];
                }
                else
                {
                    total += rightMax - height[right];
                }
                right--;
            }
        }

        return total;
    }

    public int SolveI(int[] height)
    {
        int totalTrapped = 0;
        int currentTrapped = 0;
        int n = height.Length;
        int startWidth = height[0];
        List<int> currentTrappedIndex = new List<int>();
        List<int> finalTrappedIndex = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int diff = startWidth - height[i];

            if (diff > 0)
            {
                currentTrapped += diff;
                currentTrappedIndex.Add(i);
            }

            if (height[i] >= startWidth)
            {
                startWidth = height[i];
                totalTrapped += currentTrapped;
                currentTrapped = 0;
                finalTrappedIndex.AddRange(currentTrappedIndex);
            }
        }

        currentTrapped = 0;
        startWidth = height[n - 1];
        currentTrappedIndex.Clear();
        for (int i = n - 1; i >= 0; i--)
        {
            int diff = startWidth - height[i];

            if (diff > 0)
            {
                currentTrapped += diff;
                currentTrappedIndex.Add(i);
            }

            if (height[i] >= startWidth)
            {
                if (!currentTrappedIndex.Any(x => finalTrappedIndex.Contains(x)))
                {
                    totalTrapped += currentTrapped;
                }
                currentTrapped = 0;
                startWidth = height[i];

            }
        }

        return totalTrapped;
    }
}

