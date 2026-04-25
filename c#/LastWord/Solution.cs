/*

Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal substring consisting of non-space characters only.

 

Example 1:

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
Example 2:

Input: s = "   fly me   to   the moon  "
Output: 4
Explanation: The last word is "moon" with length 4.
Example 3:

Input: s = "luffy is still joyboy"
Output: 6
Explanation: The last word is "joyboy" with length 6.
 

Constraints:

1 <= s.length <= 104
s consists of only English letters and spaces ' '.
There will be at least one word in s.

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

