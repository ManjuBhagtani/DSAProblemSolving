/*

Given a positive integer, check whether it has alternating bits: namely, if two adjacent bits will always have different values.

Example 1:

Input: n = 5
Output: true
Explanation: The binary representation of 5 is: 101


Example 2:

Input: n = 7
Output: false
Explanation: The binary representation of 7 is: 111.


Example 3:

Input: n = 11
Output: false
Explanation: The binary representation of 11 is: 1011.
 

Constraints:

1 <= n <= 2^31 - 1

*/

//Approach1:

public class Solution {
    public bool HasAlternatingBits(int n) {
        int currentBit = 0;
        int prevBit = -1;
        while(n > 0){
            currentBit = n&1;
            if(currentBit == prevBit){
                return false;
            }
            prevBit = currentBit;
            n = n>>1;
        }
        return true;
    }
}

/*
	TC = O(log N)
	SC = O(1)
*/

//Aproach 2
public class Solution {
    public bool HasAlternatingBits(int n) {
        int N = n^(n>>1); //if n has alternating bits, n^(n>>1) will give all 1s
        
        //if we add 1 to a number having all 1s, we get a no. with first bit as 1 and all remaing bits as 0. 
        //Eg. 7 = 111+1 = 8 = 1000. & this with 7. We get 0.
        if(((N+1)&N) == 0){ 
            return true;
        }
        return false;
    }
}

/*
	TC = O(1)
	SC = O(1)
*/