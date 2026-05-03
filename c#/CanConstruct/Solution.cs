/*
383. Ransom Note

Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

 

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
 

Constraints:

1 <= ransomNote.length, magazine.length <= 105
ransomNote and magazine consist of lowercase English letters.

*/
using System.Text;

public class Solution
{
    public static readonly string RansomNote = "aa";
    public static readonly string Magazine = "aab";

    // 60? time 60% memory
    public bool Solve(string ransomNote, string magazine)
    {
        Dictionary<char, int> holder = new Dictionary<char, int>();

        foreach (char mag in magazine)
        {
            holder[mag] = holder.GetValueOrDefault(mag, 0) + 1;
        }

        foreach (char ran in ransomNote)
        {
            int some = holder.GetValueOrDefault(ran, 0);

            if (some < 1)
            {
                return false;
            }

            holder[ran] = some - 1;
        }

        return true;
    }
}

