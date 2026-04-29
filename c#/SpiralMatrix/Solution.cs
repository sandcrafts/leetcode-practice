/*

54. Spiral Matrix

Given an m x n matrix, return all elements of the matrix in spiral order.

*/

public class Solution
{
    public static readonly int[][] Matrix = new int[][]
    {
        new int[] {1,2,3,4},
        new int[] {5,6,7,8},
        new int[] {9,10,11,12},
    };

    public IList<int> Solve(int[][] matrix)
    {
        // initialized with the first row. so that we can always leave the first item when crawling.
        List<int> spiralList = [.. matrix[0]];

        int rowsRemaining = matrix.Length  - 1;
        int columnsRemaining = matrix[0].Length  - 1;

        // list was initialized with the first row. We still start from the first row and go downwards
        int row = 0;
        
        // list was initialized with the first row. So,
        // we start from the last column and we have the remainingColumnCount number of columns to go
        int column = columnsRemaining;

        int length;
        int batch = 1;

        while (true)
        {
            // if value of i is 0,1 positive; 2,3 negative; 4,5 positive and so on
            bool isPositiveCrawl = ((batch / 2) % 2 == 0);
            // even i → row crawl (left/right)
            // odd i → column crawl (up/down)
            bool isRowCrawl = batch % 2 == 0;

            if (isRowCrawl)
            {
                length = columnsRemaining;
                // if we move through horizontally in a row, there is 1 less vertical step we need to make next time
                columnsRemaining--;
            }
            else
            {
                length = rowsRemaining;
                // if we move through vertically in a column, there is 1 less horizontal step we need to make next time
                rowsRemaining--;
            }

            if (length <= 0)
            {
                break;
            }


            for (int j = 0; j < length ; j++)
            {
                if (isRowCrawl)
                {
                    // we increase or decrease the column index. moving right or left
                    column += isPositiveCrawl ? 1 : -1;
                }
                else
                {
                    //column crawl: we increase or decrease the row index. moving up or down
                    row += isPositiveCrawl ? 1 : -1;
                }

                spiralList.Add(matrix[row][column]);
            }

            batch++;

        }

        return spiralList;
    }
}

