public class Solution {
    public bool check(string ansKey, int n, int k, int mid){    //O(n)
        //count the no. of Ts and Fs in every possible substring of length mid
        
        int Ts = 0;
        int Fs = 0;
        //find no. of Ts/Fs in first window of size mid
        for(int i = 0; i<mid; i++){
            if(ansKey[i] == 'T'){
                Ts++;
            }else{
                Fs++;
            }
        }
        if(Math.Max(Ts, Fs)+k >= mid){
            return true;
        }else{ //process subsequent windows of size mid
            for(int i = mid; i<n; i++){
                if(ansKey[i-mid] == 'T'){
                    Ts--;
                }else{
                    Fs--;
                }
                if(ansKey[i] == 'T'){
                    Ts++;
                }else{
                    Fs++;
                }
                if(Math.Max(Ts, Fs)+k >= mid){
                    return true;
                }
            }
        }
        return false;
    }
    public int MaxConsecutiveAnswers(string answerKey, int k) {
        //find the max no. of consecutive Ts and Fs. since min val of k = 1, there can be minimum 
        //Max(max consecutive Ts, max consecutive Fs)+1 Ts or Fs
        //The string might have all Ts or all Fs. So max consecutive Ts or Fs = answerKey.Length
        
        int n = answerKey.Length;
        
        int Ts = answerKey[0] == 'T' ? 1 : 0;
        int Fs = answerKey[0] == 'F' ? 1 : 0;
        
        int maxConsecutiveTs = Ts;
        int maxConsecutiveFs = Fs;
        
        for(int i = 1; i<n; i++){           //O(n)
            if(answerKey[i] == 'T'){
                if(answerKey[i-1] != 'T'){
                    maxConsecutiveFs = Math.Max(maxConsecutiveFs, Fs);
                    Fs = 0;
                }
                Ts++;
                //maxConsecutiveTs = Math.Max(maxConsecutiveTs, Ts);
            }else{
                if(answerKey[i-1] != 'F'){
                    maxConsecutiveTs = Math.Max(maxConsecutiveTs, Ts);
                    Ts = 0;
                }
                Fs++;
                //maxConsecutiveFs = Math.Max(maxConsecutiveFs, Fs);
            }
        }
        maxConsecutiveTs = Math.Max(maxConsecutiveTs, Ts);
        maxConsecutiveFs = Math.Max(maxConsecutiveFs, Fs);

        //range of ans = [Max(max consecutive Ts, max consecutive Fs)+1 , n]
        int low = Math.Max(maxConsecutiveTs, maxConsecutiveFs);
        int high = n;
        int ans = 0;
        while(low <= high){                 //O(logn)
            int mid = low + (high-low)/2;
            
            //can there be mid no. of consecutive Ts or Fs?
            if(check(answerKey, n, k, mid)){ //O(n) - if yes, then there can also be mid-1, mid-2 ... no. of Ts/Fs. Discard left half of search space
                ans = mid;
                low = mid+1;
            }else{
                high = mid-1;
            }
        }
        
        return ans;
        
        /*
            TC = O(n) + O(nlogn) = O(nlogn)
            SC = O(1)
        */
    }
}