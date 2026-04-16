/*
6. Zigzag Conversion
The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

string convert(string s, int numRows);
 

Example 1:

Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"
Example 2:

Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:
P     I    N
A   L S  I G
Y A   H R
P     I
Example 3:

Input: s = "A", numRows = 1
Output: "A"
 

Constraints:

1 <= s.length <= 1000
s consists of English letters (lower-case and upper-case), ',' and '.'.
1 <= numRows <= 1000
*/
using System.Text;

public class Solution
{
    public static readonly string InputString = "PAYPALISHIRING";
    public static readonly int NumRows = 3;
    
    public string Solve(string s, int numRows) {
        StringBuilder zigzag = new StringBuilder();
        Dictionary<int, List<char>> map = new Dictionary<int, List<char>>();
        bool ascend = true;
        int n = 1;

        for (int i = 0; i < s.Length; i++)
        {
            if (!map.ContainsKey(n)) {
                map[n] = new List<char>();
            }
            
            map[n].Add(s[i]);

            if (n == 1){
                ascend = true;
            } else if (n == numRows) {
                ascend = false;
            }

            if (ascend) {
                n++;
            } else {
                n--;
            }
        }

        for (int i = 1; i <= map.Count(); i++) {
            foreach(char c in map[i]) {
                zigzag.Append(c);
            }
        } 

        return zigzag.ToString();
    }
}

