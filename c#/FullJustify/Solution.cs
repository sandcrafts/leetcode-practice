/*
Given an array of strings words and a width maxWidth, format the text such that each line has exactly maxWidth characters and is fully (left and right) justified.

You should pack your words in a greedy approach; that is, pack as many words as you can in each line. Pad extra spaces ' ' when necessary so that each line has exactly maxWidth characters.

Extra spaces between words should be distributed as evenly as possible. If the number of spaces on a line does not divide evenly between words, the empty slots on the left will be assigned more spaces than the slots on the right.

For the last line of text, it should be left-justified, and no extra space is inserted between words.

Note:

A word is defined as a character sequence consisting of non-space characters only.
Each word's length is guaranteed to be greater than 0 and not exceed maxWidth.
The input array words contains at least one word.

Example 1:

Input: words = ["This", "is", "an", "example", "of", "text", "justification."], maxWidth = 16
Output:
[
   "This    is    an",
   "example  of text",
   "justification.  "
]
Example 2:

Input: words = ["What","must","be","acknowledgment","shall","be"], maxWidth = 16
Output:
[
  "What   must   be",
  "acknowledgment  ",
  "shall be        "
]
Explanation: Note that the last line is "shall be    " instead of "shall     be", because the last line must be left-justified instead of fully-justified.
Note that the second line is also left-justified because it contains only one word.
Example 3:

Input: words = ["Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"], maxWidth = 20
Output:
[
  "Science  is  what we",
  "understand      well",
  "enough to explain to",
  "a  computer.  Art is",
  "everything  else  we",
  "do                  "
]

Constraints:

1 <= words.length <= 300
1 <= words[i].length <= 20
words[i] consists of only English letters and symbols.
1 <= maxWidth <= 100
words[i].length <= maxWidth
*/
using System.Text;

public class Solution
{
    public static readonly string[] InputWords =
    [
        "Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"
    ];
    public static readonly int MaxWidth = 20;

    public IList<string> Solve(string[] words, int maxWidth)
    {
        List<string> lineContents = new List<string>();
        List<string> final = new List<string>();
        int currentLineWidthWithoutSpaces = 0;
        int n = words.Length;

        for (int i = 0; i < n; i++)
        {
            if (currentLineWidthWithoutSpaces + lineContents.Count + words[i].Length > maxWidth)
            {
                int equalSpace;
                int extraSpace = 0;
                int remainingSpaces = maxWidth - currentLineWidthWithoutSpaces;
                int currentLineWordCount = lineContents.Count;

                if (currentLineWordCount > 1)
                {
                    equalSpace = remainingSpaces / (currentLineWordCount - 1);
                    extraSpace = remainingSpaces % (currentLineWordCount - 1);
                }
                else
                {
                    equalSpace = remainingSpaces;
                }

                StringBuilder finalLine = new StringBuilder();

                for (int k = 0; k < currentLineWordCount; k++)
                {
                    finalLine.Append(lineContents[k]);

                    if ((k == (currentLineWordCount - 1)) && (currentLineWordCount != 1))
                    {
                        break;
                    }
                    for (int j = 1; j <= equalSpace; j++)
                    {
                        finalLine.Append(" ");
                    }

                    if (extraSpace > 0)
                    {
                        finalLine.Append(" ");
                        extraSpace--;
                    }

                }

                final.Add(finalLine.ToString());
                lineContents.Clear();
                currentLineWidthWithoutSpaces = 0;
            }

            lineContents.Add(words[i]);
            currentLineWidthWithoutSpaces += words[i].Length;

            if (n == 1 || i == n - 1)
            {
                StringBuilder finalLine = new StringBuilder();
                int endSpace = maxWidth - currentLineWidthWithoutSpaces - (lineContents.Count - 1);

                for (int q = 0; q < lineContents.Count; q++)
                {
                    finalLine.Append(lineContents[q]);

                    if (q != lineContents.Count - 1)
                    {
                        finalLine.Append(" ");
                    }
                }

                for (int r = 1; r <= endSpace; r++)
                {
                    finalLine.Append(" ");
                }

                final.Add(finalLine.ToString());
            }
        }

        return final;
    }
}

