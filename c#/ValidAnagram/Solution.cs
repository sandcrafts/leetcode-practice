/*
242. Valid Anagram

Given two strings s and t, return true if t is an anagram of s, and false otherwise.

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false

Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.

Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
*/
using System.Text;

public class Solution
{
    public static readonly string S = "anagram";
    public static readonly string T = "anagram";

    public bool Solve(string s, string t)
    {
        Dictionary<char, int> holder = new Dictionary<char, int>();

        foreach (char alpha in s)
        {
            int count = holder.GetValueOrDefault(alpha, 0);
            holder[alpha] = count++;
        }

        foreach (char alpha in t)
        {
            if (!holder.TryGetValue(alpha, out int count) || count <= 0)
            {
                return false;
            }

            holder[alpha] = count--;
        }

        foreach (int value in holder.Values)
        {
            if (value != 0)
            {
                return false;
            }
        }

        return true;
    }
}

