/*

392. Is Subsequence

Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

 

Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true
Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false
 

Constraints:

0 <= s.length <= 100
0 <= t.length <= 104
s and t consist only of lowercase English letters.
 

Follow up: Suppose there are lots of incoming s, say s1, s2, ..., sk where k >= 109, and you want to check one by one to see if t has its subsequence. In this scenario, how would you change your code?

*/
public class Solution
{
    public static readonly string T = "ahbgdc";
    public static readonly string S = "abc";

    public bool Solve(string s, string t)
    {
        int sIndex = 0;
        int tIndex = 0;

        while (sIndex < s.Length && tIndex < t.Length)
        {
            if (s[sIndex] == t[tIndex])
            {
                sIndex++;
            }

            tIndex++;
        }

        return sIndex == s.Length;
    }

    public bool SolveI(string s, string t)
    {
        if (s.Length == 0)
        {
            return true;
        }
        int tLeft = 0;
        int tRight = t.Length - 1;
        int sLeft = 0;
        int sRight = s.Length - 1;

        while (tLeft <= tRight)
        {
            if (tLeft == tRight && sLeft < sRight)
            {
                return false;
            }

            if (t[tLeft] != s[sLeft])
            {
                tLeft++;
                continue;
            }
            if (t[tRight] != s[sRight])
            {
                tRight--;
                continue;
            }

            if (sLeft == sRight && tLeft == tRight)
            {
                return true;
            }

            sLeft++;
            sRight--;
            tLeft++;
            tRight--;

            if (sLeft > sRight)
            {
                return true;
            }

        }

        return false;
    }
}

