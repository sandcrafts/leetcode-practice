/*
274. H-Index

Given an array of integers citations where citations[i] is the number of citations a researcher received for their ith paper, return the researcher's h-index.

According to the definition of h-index on Wikipedia: The h-index is defined as the maximum value of h such that the given researcher has published at least h papers that have each been cited at least h times.

Example 1:
Input: citations = [3,0,6,1,5]
Output: 3
Explanation: [3,0,6,1,5] means the researcher has 5 papers in total and each of them had received 3, 0, 6, 1, 5 citations respectively.
Since the researcher has 3 papers with at least 3 citations each and the remaining two with no more than 3 citations each, their h-index is 3.
Example 2:
Input: citations = [1,3,1]
Output: 1
 
Constraints:

n == citations.length
1 <= n <= 5000
0 <= citations[i] <= 1000
*/

public class Solution
{
    public static readonly int[] Input = new int[] {3,0,6,1,5};

    public int Solve(int[] citations) {
        if (citations.Length == 1 && citations[0] != 0) {
            return 1;
        }

        for (int i = citations.Length; i > 0; i--)
        {
            int count = 0;
            foreach (int citation in citations) {
                if (citation >= i)
                {
                    count++;
                }
            }

            if (count >= i) {
                return i;
            }
        }

        return 0;
    }

    public int SolveII(int[] citations) {
        if (citations.Length == 1 && citations[0] != 0) {
            return 1;
        }

        for (int i = citations.Length; i > 0; i--)
        {
            int count = 0;
            int minValue = 1000; 
            foreach (int citation in citations) {
                if (citation >= i)
                {
                    count++;
                    if (citation < minValue) {
                        minValue = citation;
                    }
                }
            }

            if (count >= i) {
                return Math.Min(minValue, count);
            }
        }

        return 0;
    }
}

