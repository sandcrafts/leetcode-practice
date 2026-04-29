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
        List<int> spiralList = new List<int>();
        foreach (int value in matrix[0])
        {
            spiralList.Add(value);
        }



        bool isRow = false;
        int rowCount = matrix.Length;
        int columnCount = matrix[0].Length;

        int row = 0;
        int column = columnCount - 1;

        int length = rowCount - 1;
        bool positive = true;
        int i = 1;



        while (true)
        {
            positive = (i / 2) % 2 == 0 ? true : false;

            if (i % 2 == 0)
            {
                length = columnCount--;
                isRow = true;
            }
            else
            {
                length = rowCount--;
                isRow = false;
            }

            if (length <= 0)
            {
                break;
            }


            for (int j = 0; j < length; j--)
            {
                if (isRow)
                {
                    if (positive)
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
                    if (positive)
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

