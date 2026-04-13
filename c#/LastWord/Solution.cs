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
    public static readonly string Input = "   fly me   to   the moon  ";

    public int Solve(string s)
    {
        bool charFound = false;
        int total = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                charFound = true;
            }

            if (charFound)
            {
                if (s[i] == ' ')
                {
                    return total;
                }
                total++;
            }
        }

        return total;
    }

    public int SolveI(string s)
    {
        string[] exploded = s.Trim().Split(' ');

        string lastWord = exploded[exploded.Length - 1];

        return lastWord.Length;
    }
}

