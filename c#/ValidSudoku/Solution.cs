/*
55. Jump Game
Medium
Topics
premium lock icon
Companies
You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.

Return true if you can reach the last index, or false otherwise.

 

Example 1:

Input: nums = [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
Example 2:

Input: nums = [3,2,1,0,4]
Output: false
Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.
 

Constraints:

1 <= nums.length <= 104
0 <= nums[i] <= 105

*/

public class Solution
{
    public static readonly char[][] Board = new char[][]
    {
        new char[] {'5','3','.','.','7','.','.','.','.'},
        new char[] {'6','.','.','1','9','5','.','.','.'},
        new char[] {'.','9','8','.','.','.','.','6','.'},
        new char[] {'8','.','.','.','6','.','.','.','3'},
        new char[] {'4','.','.','8','.','3','.','.','1'},
        new char[] {'7','.','.','.','2','.','.','.','6'},
        new char[] {'.','6','.','.','.','.','2','8','.'},
        new char[] {'.','.','.','4','1','9','.','.','5'},
        new char[] {'.','.','.','.','8','.','.','7','9'}
    };

    public bool Solve(char[][] board)
    {
        HashSet<char> row = new HashSet<char>();
        HashSet<char> column = new HashSet<char>();
        HashSet<char> section = new HashSet<char>();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }
                if (row.Contains(board[i][j]))
                {
                    return false;
                }
                row.Add(board[i][j]);
            }

            row.Clear();
        }

        for (int i = 0; i < board[0].Length; i++)
        {
            for (int j = 0; j < board.Length; j++)
            {
                if (board[j][i] == '.')
                {
                    continue;
                }
                if (column.Contains(board[j][i]))
                {
                    return false;
                }
                column.Add(board[j][i]);
            }

            column.Clear();
        }

        for (int k = 0; k < board.Length; k += 3)
        {
            for (int l = 0; l < board[0].Length; l += 3)
            {
                for (int m = k; m < k + 3; m++)
                {
                    for (int n = l; n < l + 3; n++)
                    {
                        if (board[m][n] == '.')
                        {
                            continue;
                        }

                        if (section.Contains(board[m][n]))
                        {
                            return false;
                        }

                        section.Add(board[m][n]);
                    }
                }

                section.Clear();
            }
        }

        return true;
    }
}

