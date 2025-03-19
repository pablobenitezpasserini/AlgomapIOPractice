
namespace _121BestTimeToBuyAndSellStock;

class Program
{
    static void Main(string[] args)
    {
        // link https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
    }
    public static int MaxProfit(int[] prices) {
        int maxP = 0;
        int l = 0;
        int r = 1;
        int profit = 0;

        while(r < prices.Length)
        {
            if(prices[l] < prices[r])
            {
                profit = prices[r] - prices[l];
                maxP = Math.Max(profit, maxP);
            }
            else
            {
                l = r;
            }
            r++;
        }
        return maxP;
    }
}
