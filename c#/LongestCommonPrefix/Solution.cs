/*
14. Longest Common Prefix
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters if it is non-empty.
*/

public class Solution
{
    public static readonly string[] Input = new string[] {"flower","flow","flight"};

    public string Solve(string[] strs) {
        if (strs.Length == 0)
        {
            return "";
        }

        string longest = strs[0];

        for(int i = 0; i < strs.Length; i++){
            string currentString = strs[i];
            if (currentString == ""){
                return "";
            }

            if (longest.Length > currentString.Length) 
            {
                longest = longest[..currentString.Length];
            }

            for (int j = 0; j < longest.Length; j++) {
                if (currentString[j] != longest[j])
                {
                    longest = longest.Substring(0, j);
                    break;
                }
            }
        }

        return longest;
    }
}

