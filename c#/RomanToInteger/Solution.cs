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
    public static readonly string Input = "MCMXCIV";

        public int Solve(string s) {
        Dictionary<char, int> romanIntMap = new Dictionary<char, int> {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] =10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        int length = s.Length;

        char[] romans = s.ToCharArray();

        int intTotal = romanIntMap[romans[length - 1]];

        for (int i = length - 2; i >= 0; i--) {
            if (romanIntMap[romans[i]] < romanIntMap[romans[i+1]]) {
                intTotal -= romanIntMap[romans[i]];

                continue;
            }

            intTotal += romanIntMap[romans[i]];
        }

        return intTotal;
    }
}

