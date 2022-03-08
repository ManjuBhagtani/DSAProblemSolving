public class Solution {
    public int AddDigits(int num) {
        // int sum = 0;
        // while(num > 0){
        //     int rem = num%10;
        //     sum += rem;
        //     num /= 10;
        //     if(num == 0){
        //         if(sum >= 10){
        //             num = sum;
        //             sum = 0;
        //         }
        //     }
        // }
        
        // return sum;
        
        //O(1) solution below:
        if(num == 0){
            return 0;
        }
        if(num%9 == 0){
            return 9;
        }
        return num%9;
    }
}