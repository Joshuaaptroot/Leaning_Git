public class Solution {
    public int MaxProfit(int[] prices) {
        int candidate = 0;
        int Lownum = 0;
        int dif = 0;
        int highestDif = 0;

        for (int i = 0 ; i < prices.Length;i++) {
           candidate = prices[i];

            if (i == 0){
                Lownum = prices[i];
            }
           
            if (prices[i] < Lownum) {
                Lownum = prices[i];
            }
            else {
                dif = candidate - Lownum;
                if (dif > highestDif) {
                    highestDif = dif;
                }
            }
           
        }
        return highestDif;
    }
}