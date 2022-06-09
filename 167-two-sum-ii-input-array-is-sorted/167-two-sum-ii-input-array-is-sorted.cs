public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n = numbers.Length;
        int p1 = 0;
        int p2 = n-1;
        
        int[] ans = new int[2];
        
        while(p1 < n && p2 >= 0 && p1 < p2){
            int sum = numbers[p1]+numbers[p2];
            if(sum > target){
                p2--;
            }else if(sum < target){
                p1++;
            }else{
                ans[0] = p1+1;
                ans[1] = p2+1;
                break;
            }
        }
        
        return ans;
        
        /*
            TC = O(n)
            SC = O(1)
        */
    }
}