/*
28. Find the Index of the First Occurrence in a String
Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

 

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.
Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
 

Constraints:

1 <= haystack.length, needle.length <= 104
haystack and needle consist of only lowercase English characters.
*/

public class Solution
{
    public static readonly string HAYSTACK = "sadbutsad";
    public static readonly string NEEDLE = "sad";

    public int Solve(string haystack, string needle)
    {
        int index = -1;
        for (int i = 0; i <= (haystack.Length - needle.Length); i++)
        {
            if (haystack[i] == needle[0])
            {
                if (needle.Length == 1)
                {
                    return i;
                }

                for (int j = 1; j < needle.Length; j++)
                {
                    if (!(needle[j] == haystack[i + j]))
                    {
                        break;
                    }

                    if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
            }
        }

        return index;
    }

    public int SolveI(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }
}

