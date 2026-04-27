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
using System.Text;

public class Solution
{
    public static readonly string S = "ADOBECODEBANC";
    public static readonly string T = "ABC";

    public string Solve(string s, string t)
    {
        string str = "";
        StringBuilder strTmp = new StringBuilder();
        int substringLength = t.Length;
        int stringLength = s.Length;
        // int left = 0;
        int count = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach(char c in t) {
            map[c] = map.GetValueOrDefault(c, 0) + 1;
        }

        Dictionary<char, int> window = new Dictionary<char, int>();

        for(int right = 0; right < stringLength; right++) {
            if (map.ContainsKey(s[right])) {
                strTmp.Append(s[right]);
                window[s[right]] = window.GetValueOrDefault(s[right], 0) + 1;
                if (window[s[right]] <= map[s[right]]) {
                    count ++;
                }

                if (count == substringLength) {
                    if (strTmp.Length < str.Length || str == "") {
                        str = strTmp.ToString();
                    }

                    strTmp.Clear();
                    window.Clear();
                    count = 0;
                }
            } else if (count > 0) {
                strTmp.Append(s[right]);
            }

        }

        return str;
    }
}

