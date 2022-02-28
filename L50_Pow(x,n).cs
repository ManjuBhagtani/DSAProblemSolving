/*

Implement pow(x, n), which calculates x raised to the power n (i.e., xn).

Example 1:

Input: x = 2.00000, n = 10
Output: 1024.00000


Example 2:

Input: x = 2.10000, n = 3
Output: 9.26100


Example 3:

Input: x = 2.00000, n = -2
Output: 0.25000
Explanation: 2-2 = 1/22 = 1/4 = 0.25
 

Constraints:

-100.0 < x < 100.0
-2^31 <= n <= 2^31-1
-10^4 <= x^n <= 10^4

*/

public class Solution {
    
    public double pow(double x, int n){

        if(n == 0){
            return 1;
        }
        double halfPower = pow(x, n/2);

        double halfAns = halfPower*halfPower;

        if(n % 2 == 0){
            return halfAns;
        }else{
            return halfAns*x;
        }
    }
    
    public double MyPow(double x, int n) {
        double ans = pow(x, n);
        if(n < 0){
            return 1/ans;
        }
        return ans;
    }
}

/*
    TC = O(log n)
    SC = O(log n)
*/