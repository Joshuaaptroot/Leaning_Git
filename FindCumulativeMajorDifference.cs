public class Solution {
    public int MaxProfit(int[] prices) {
        int candidate = 0;
        int comparison = 0;
        int potentialprofit = 0;
        int profit = 0;

        for (int i = 0 ; i< prices.Length;i++) {
            
            if ( i > 0 ){ 
            comparison = prices[i];
            }
            if (candidate < comparison){
                potentialprofit = comparison - candidate;
                profit = profit + potentialprofit;
            }

            candidate = prices[i];
        }

        return profit;
    }
}