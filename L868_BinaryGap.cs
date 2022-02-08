/*
Given a positive integer n, find and return the longest distance between any two adjacent 1's in the binary representation of n. If there are no two adjacent 1's, return 0.

Two 1's are adjacent if there are only 0's separating them (possibly no 0's). The distance between two 1's is the absolute difference between their bit positions. For example, the two 1's in "1001" have a distance of 3.

Example 1:

Input: n = 22
Output: 2
Explanation: 22 in binary is "10110".
The first adjacent pair of 1's is "10110" with a distance of 2.
The second adjacent pair of 1's is "10110" with a distance of 1.
The answer is the largest of these two distances, which is 2.
Note that "10110" is not a valid pair since there is a 1 separating the two 1's underlined.


Example 2:

Input: n = 8
Output: 0
Explanation: 8 in binary is "1000".
There are not any adjacent pairs of 1's in the binary representation of 8, so we return 0.


Example 3:

Input: n = 5
Output: 2
Explanation: 5 in binary is "101".
 

Constraints:

1 <= n <= 10^9


*/

public class Solution {
    public int BinaryGap(int n) {
        int count = 0;  //tracks the current gap between any two adjacent 1s
        int maxGap = 0; //tracks the max gap between any two adjacent 1s
        
        //found1 tracks whether we have found a 1 yet. 
        //Will remain false till we get a 1 when we start checking the bits from LSB
        bool found1 = false; 
        
        //Keep checking bits starting from rightmost bit i.e. LSB
        while(n > 0){
            if((n&1) == 1){ //any number & 1 gives 1 if the last bit of number is 1, else 0
                if(found1){
                    maxGap = Math.Max(maxGap, count+1);
                    count = 0;
                }else{
                    found1 = true;
                }
            }else{  //if the last bit is 0 and we haven't found a 1 yet, do nothing
                //currently, the last bit in the number 0 and there was a 1 bit encountered previously. 
                //That means this 0 lies between that previous 1 and the next 1 we will encounter. 
                //So increment count 
                if(found1){
                    count++;
                }
            }
            n = n>>1; //rightshift n
        }
        return maxGap;
        
    }
}

/*
	TC = O(log n)
	SC = O(1)
*/