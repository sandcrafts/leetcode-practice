/*

54. Spiral Matrix

Given an m x n matrix, return all elements of the matrix in spiral order.

Example 1:


Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,3,6,9,8,7,4,5]
Example 2:


Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
Output: [1,2,3,4,8,12,11,10,9,5,6,7]
 

Constraints:

m == matrix.length
n == matrix[i].length
1 <= m, n <= 10
-100 <= matrix[i][j] <= 100

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

        // list was initialized with the first row. We still start from the first row and go downwards
        int row = 0;
        
        // list was initialized with the first row. So,
        // we start from the last column. index is 1 less than count.
        int column = matrix[0].Length - 1;

        int verticalStepsRemaining = matrix.Length  - 1;
        int horizontalStepsRemaining = matrix[0].Length;

        int length;
        int batch = 1;

        while (true)
        {
            // if value of i is 0,1 positive; 2,3 negative; 4,5 positive and so on
            bool isPositiveCrawl = ((batch / 2) % 2 == 0);
            // even i → horizontal crawl (left/right)
            // odd i → vertical crawl (up/down)
            bool isHorizontalCrawl = batch % 2 == 0;


            // since first row was already added, we start with vertical crawl
            if (isHorizontalCrawl)
            {
                length = horizontalStepsRemaining;
                // after we do a horizontal walk, there is 1 less vertical step for future
                verticalStepsRemaining--;
            }
            else
            {
                length = verticalStepsRemaining;
                // after we do a vertical walk, there is 1 less horizontal step for future
                horizontalStepsRemaining--;
            }

            if (length <= 0)
            {
                break;
            }


            for (int j = 0; j < length ; j++)
            {
                if (isHorizontalCrawl)
                {
                    // we increase or decrease the column index. moving right or left
                    column += isPositiveCrawl ? 1 : -1;
                }
                else
                {
                    //vertical crawl: we increase or decrease the row index. moving up or down
                    row += isPositiveCrawl ? 1 : -1;
                }

                spiralList.Add(matrix[row][column]);
            }

            batch++;

        }

        return spiralList;
    }
}

