/*
56. Merge Intervals

Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

Example 1:

Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
Example 2:

Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.
Example 3:

Input: intervals = [[4,7],[1,4]]
Output: [[1,7]]
Explanation: Intervals [1,4] and [4,7] are considered overlapping.
 

Constraints:

1 <= intervals.length <= 104
intervals[i].length == 2
0 <= starti <= endi <= 104
*/

public class Solution
{
    public static readonly int[][] Intervals = new int[][]
    {
        new int[] {1,3},
        new int[] {2,6},
        new int[] {8,10},
        new int[] {15,18},
    };

    public int[][] Solve(int[][] intervals)
    {
        if (intervals.Length <= 1)
        {
            return intervals;
        }

        List<int[]> holder = new List<int[]>();

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        int start = intervals[0][0];
        int end = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= end)
            {
                end = Math.Max(intervals[i][1], end);
            }
            else
            {
                holder.Add([start, end]);
                start = intervals[i][0];
                end = intervals[i][1];
            }

            if (i == intervals.Length - 1)
            {
                holder.Add([start, end]);
            }
        }

        return holder.ToArray();
    }

    public int[][] SolveI(int[][] intervals)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int[]> holder = new List<int[]>();

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        for (int i = 0; i < intervals.Length; i++)
        {
            if (seen.Contains(i))
            {
                continue;
            }

            if (i == intervals.Length - 1)
            {
                holder.Add(intervals[i]);
                break;
            }

            seen.Add(i);

            int start = intervals[i][0];
            int end = intervals[i][1];

            for (int j = i + 1; j < intervals.Length; j++)
            {
                if (intervals[j][0] <= end)
                {
                    seen.Add(j);
                    end = Math.Max(intervals[j][1], end);
                }
            }

            holder.Add([start, end]);

        }

        return holder.ToArray();
    }
}