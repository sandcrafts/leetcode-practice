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

        int remainingRowCount = matrix.Length  - 1;
        int remainingColumnCount = matrix[0].Length  - 1;


        // list was initialized with the first row. We still start from the first row and go downwards
        int row = 0;
        
        // list was initialized with the first row. So,
        // we start from the last column and we have the remainingColumnCount number of columns to go
        int column = remainingColumnCount;

        int length;
        bool isRowCrawl;
        bool isPositiveCrawl;
        int i = 1;

        while (true)
        {
            // if value of i is 0,1 positive; 2,3 negative; 4,5 positive and so on
            isPositiveCrawl = i / 2 % 2 == 0;

            // if i is odd, it is a columnCrawl else it is a rowCrawl
            if (i % 2 == 0)
            {
                length = remainingColumnCount;
                //everytime we crawl through a column, there is 1 less column to crawl next time.
                remainingColumnCount--;
                isRowCrawl = true;
            }
            else
            {
                length = remainingRowCount;
                //everytime we crawl through a row, there is 1 less row to crawl next time.
                remainingRowCount--;
                isRowCrawl = false;
            }

            if (length <= 0)
            {
                break;
            }


            for (int j = 0; j < length ; j++)
            {
                if (isRowCrawl)
                {
                    if (isPositiveCrawl)
                    {
                        column++;
                    }
                    else
                    {
                        column--;
                    }
                }
                else
                {
                    if (isPositiveCrawl)
                    {
                        row++;
                    }
                    else
                    {
                        row--;
                    }
                }

                spiralList.Add(matrix[row][column]);
            }

            i++;

        }

        return spiralList;
    }
}

