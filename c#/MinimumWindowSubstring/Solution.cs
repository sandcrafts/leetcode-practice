/*
76. Minimum Window Substring

Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that every character in t (including duplicates) is included in the window. If there is no such substring, return the empty string "".

The testcases will be generated such that the answer is unique.

 

Example 1:

Input: s = "ADOBECODEBANC", t = "ABC"
Output: "BANC"
Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
Example 2:

Input: s = "a", t = "a"
Output: "a"
Explanation: The entire string s is the minimum window.
Example 3:

Input: s = "a", t = "aa"
Output: ""
Explanation: Both 'a's from t must be included in the window.
Since the largest window of s only has one 'a', return empty string.
 

Constraints:

m == s.length
n == t.length
1 <= m, n <= 105
s and t consist of uppercase and lowercase English letters.
 

Follow up: Could you find an algorithm that runs in O(m + n) time?

*/
using System.Text;

public class Solution
{
    public static readonly string S = "ADOBECODEBANC";
    public static readonly string T = "ABC";

    public string Solve(string s, string t)
    {
        int start = 0;
        int minLen = int.MaxValue;
        int left = 0;

        int substringLength = t.Length;
        int stringLength = s.Length;

        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (char c in t)
        {
            map[c] = map.GetValueOrDefault(c, 0) + 1;
        }

        Dictionary<char, int> window = new Dictionary<char, int>();

        int count = 0;

        for (int right = 0; right < stringLength; right++)
        {
            char current = s[right];
            if (map.ContainsKey(current))
            {
                window[current] = window.GetValueOrDefault(current, 0) + 1;
                if (window[current] <= map[current])
                {
                    count++;
                }
            }

            while (count == substringLength)
            {
                if (right - left + 1 < minLen)
                {
                    start = left;
                    minLen = right - left + 1;
                }

                char leftChar = s[left];
                if (map.ContainsKey(leftChar))
                {
                    window[leftChar] = window.GetValueOrDefault(leftChar, 0) - 1;
                    if (window[leftChar] < map[leftChar])
                    {
                        count--;
                    }
                }
                left++;
            }
        }

        return s.Substring(start, minLen == int.MaxValue ? 0 : minLen);
    }

    public string SolveI(string s, string t)
    {
        string str = "";
        StringBuilder strTmp = new StringBuilder();
        int substringLength = t.Length;
        int stringLength = s.Length;
        // int left = 0;
        int count = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (char c in t)
        {
            map[c] = map.GetValueOrDefault(c, 0) + 1;
        }

        Dictionary<char, int> window = new Dictionary<char, int>();

        for (int right = 0; right < stringLength; right++)
        {
            if (map.ContainsKey(s[right]))
            {
                strTmp.Append(s[right]);
                window[s[right]] = window.GetValueOrDefault(s[right], 0) + 1;
                if (window[s[right]] <= map[s[right]])
                {
                    count++;
                }

                if (count == substringLength)
                {
                    if (strTmp.Length < str.Length || str == "")
                    {
                        str = strTmp.ToString();
                    }

                    strTmp.Clear();
                    window.Clear();
                    count = 0;
                }
            }
            else if (count > 0)
            {
                strTmp.Append(s[right]);
            }

        }

        return str;
    }
}

