/*

202. Happy Number

Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

Starting with any positive integer, replace the number by the sum of the squares of its digits.
Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy.
Return true if n is a happy number, and false if not.

 

Example 1:

Input: n = 19
Output: true
Explanation:
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1
Example 2:

Input: n = 2
Output: false
 

Constraints:

1 <= n <= 231 - 1

*/

public class Solution
{
    public static readonly int N = 19;

    public bool Solve(int n)
    {
        HashSet<int> squares = new HashSet<int>();
        string str = n.ToString();

        while (true)
        {
            int sum = 0;
            foreach (char character in str)
            {
                int digit = character - '0';
                sum += digit * digit;
            }

            if (sum == 1)
            {
                return true;
            }

            if (squares.Contains(sum))
            {
                return false;
            }

            squares.Add(sum);
            str = sum.ToString();
        }
    }

    public bool SolveI(int n)
    {
        HashSet<int> squares = new HashSet<int>();

        while (n != 1 && !squares.Contains(n))
        {
            squares.Add(n);
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }

            n = sum;
        }

        return n == 1;
    }
}

