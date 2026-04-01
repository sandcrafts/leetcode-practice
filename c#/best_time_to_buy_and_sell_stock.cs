/*
121. Best Time to Buy and Sell Stock

You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.
*/
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int minPrice = prices[0];
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                int profit = prices[i] - minPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
        }

        return maxProfit;
    }
}

public class TimedOutSolution
{
    public int MaxProfit(int[] prices)
    {
        int highestDiff = 0;
        int diff = 0;
        for (int i = prices.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                diff = prices[i] - prices[j];

                if (diff > highestDiff)
                {
                    highestDiff = diff;
                }
            }
        }

        return highestDiff;
    }
}

public class IncorrectSolution
{
    public int MaxProfit(int[] prices)
    {
        int smallest = prices[0];
        int smallestIndex = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i] <= smallest)
            {
                smallest = prices[i];
                smallestIndex = i;
            }
        }

        int greatest = 0;

        for (int j = smallestIndex + 1; j < prices.Length; j++)
        {
            if (prices[j] > greatest)
            {
                greatest = prices[j];
            }
        }

        if (greatest <= smallest)
        {
            return 0;
        }
        else
        {
            return greatest - smallest;
        }
    }
}