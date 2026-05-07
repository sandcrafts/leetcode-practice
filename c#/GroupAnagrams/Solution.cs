/*
49. Group Anagrams

Given an array of strings strs, group the anagrams together. You can return the answer in any order.

 

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]

Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Explanation:

There is no string in strs that can be rearranged to form "bat".
The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.
Example 2:

Input: strs = [""]

Output: [[""]]

Example 3:

Input: strs = ["a"]

Output: [["a"]]

 

Constraints:

1 <= strs.length <= 104
0 <= strs[i].length <= 100
strs[i] consists of lowercase English letters.
*/
using System.Text;

public class Solution
{
    public static readonly string[] Strs =
    [
        "eat","tea","tan","ate","nat","bat"
    ];

    public IList<IList<string>> Solve(string[] strs)
    {
        List<IList<string>> result = new List<IList<string>>();
        Dictionary<string, List<string>> holder = new Dictionary<string, List<string>>();
        
        foreach(string str in strs) {
            char[] tmpStr = str.ToCharArray();
            
            
            for (int i = 0; i < str.Length; i++) {
                int lowestIndex = i;

                for (int j = i + 1; j < str.Length; j++) {
                    if (tmpStr[j] < tmpStr[lowestIndex]) {
                        lowestIndex = j;
                    }
                }

                char current = tmpStr[i];
                tmpStr[i] = tmpStr[lowestIndex];
                tmpStr[lowestIndex] = current;
            }

            string sorted = new string(tmpStr);

            if (holder.TryGetValue(sorted, out List<string>? strList)) {
                strList.Add(str);
                holder[sorted] = strList;
            } else
            {
                holder[sorted] = new List<string> {str};
            }
        }

        foreach(List<string> finalList in holder.Values) {
            result.Add(finalList);
        }

        return result;
    }
}

