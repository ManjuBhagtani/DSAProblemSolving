public class Solution {
    public int CountPrimes(int n) {
        if(n <= 2){
            return 0;
        }
        
        bool[] p = new bool[n];

        p[0] = false;
        p[1] = false;

        //Initially consider all numbers are prime
        for(int i = 2; i<n; i++){
            p[i]=true;
        }
        
        int count = 0;
        
        for(int i = 2; i*i < n; i++){
            if(p[i]){   //i is prime
                for(int j = i*i; j<n; j+=i){
                    p[j] = false;
                }
            }
        }
        
        for(int i = 0; i<n; i++){
            if(p[i]){
                count++;
            }
        }
        return count;
        
        /*
            TC = O(n * loglogn)
            SC = O(n)
        */
    }
}