/*

36. Valid Sudoku

Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
Note:

A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.
Input: board = 
[["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: true
Example 2:

Input: board = 
[["8","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: false
Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
 

Constraints:

board.length == 9
board[i].length == 9
board[i][j] is a digit 1-9 or '.'.

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

