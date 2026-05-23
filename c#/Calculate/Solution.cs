/*

224. Basic Calculator

Given a string s representing a valid expression, implement a basic calculator to evaluate it, and return the result of the evaluation.

Note: You are not allowed to use any built-in function which evaluates strings as mathematical expressions, such as eval().

Example 1:

Input: s = "1 + 1"
Output: 2
Example 2:

Input: s = " 2-1 + 2 "
Output: 3
Example 3:

Input: s = "(1+(4+5+2)-3)+(6+8)"
Output: 23
 

Constraints:

1 <= s.length <= 3 * 105
s consists of digits, '+', '-', '(', ')', and ' '.
s represents a valid expression.
'+' is not used as a unary operation (i.e., "+1" and "+(2 + 3)" is invalid).
'-' could be used as a unary operation (i.e., "-1" and "-(2 + 3)" is valid).
There will be no two consecutive operators in the input.
Every number and running calculation will fit in a signed 32-bit integer.

*/
public class Solution
{
    public static readonly string Input = "(1+(4+5+2)-3)+(6+8)";

    public int Solve(string s)
    {
        Stack<int> holder = new Stack<int>();

        int num = 0;
        int current = 0;
        int sign = 1;

        foreach (char alpha in s)
        {
            if (alpha == '+')
            {
                current += sign * num;
                num = 0;
                sign = 1;
            }
            else if (alpha == '-')
            {
                current += sign * num;
                num = 0;
                sign = -1;
            }
            else if ('(' == alpha)
            {
                current += sign * num;
                num = 0;
                holder.Push(current);
                holder.Push(sign);
                current = 0;
                sign = 1;
            }
            else if (')' == alpha)
            {
                current += sign * num;
                num = 0;
                int previousSign = holder.Pop();
                int previousNumber = holder.Pop();

                current = previousNumber + previousSign * current;
            }
            else if (' ' == alpha)
            {
                continue;
            }
            else
            {
                num = num * 10 + (alpha - '0');
            }
        }
        current += sign * num;

        return current;
    }
}

