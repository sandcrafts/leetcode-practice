/*
3. Longest Substring Without Repeating Characters

Given a string s, find the length of the longest substring without duplicate characters.
Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.

*/
public class Solution
{
    public static readonly string Input = "abcabcbb";

    //cleaner solution but only beats 54%
    public int Solve(string s)
    {
        int left = 0;
        HashSet<char> container = new HashSet<char>();
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (container.Contains(s[right]))
            {
                container.Remove(s[left]);
                left++;
            }

            container.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }

    // faster solution beats 83%
    public int SolveI(string s)
    {
        int left = 0;
        HashSet<char> container = new HashSet<char>();
        int maxLength = 1;

        if (s.Length == 0)
        {
            return 0;
        }

        for (int right = 0; right < s.Length; right++)
        {
            if (!container.Contains(s[right]))
            {
                container.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            else
            {
                while (left < right)
                {
                    if (s[right] == s[left])
                    {
                        left++;
                        break;
                    }

                    container.Remove(s[left]);
                    left++;
                }
            }
        }

        return maxLength;
    }
}

