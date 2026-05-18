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
    public static readonly string S = "()[]{}";


    public bool Solve(string s)
    {
                Dictionary<char, char> mapping = new Dictionary<char, char>();
        mapping['{'] = '}'; 
        mapping['('] = ')'; 
        mapping['['] = ']';
        
        Stack<char> holder = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (holder.Count == 0)
            {
                holder.Push(s[i]);
                continue;
            }

                char lastStackValue = holder.Peek();
                if (mapping.TryGetValue(lastStackValue, out char x) && x == s[i])
                {
                    holder.Pop();
                } 
             else
            {
                holder.Push(s[i]);
            }
        }

        return holder.Count == 0;
    }
}

