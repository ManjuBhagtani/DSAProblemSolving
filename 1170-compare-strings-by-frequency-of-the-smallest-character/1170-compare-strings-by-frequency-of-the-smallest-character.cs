public class Solution {
    
    public int findFreqLexSmallest(string word){        //O(m), m = length of longest string
        int n = word.Length;
        int[] freq = new int[26];
        foreach(char c in word){ //get the freq of every character
            freq[c-'a']++;
        }
        for(int i = 0; i<26; i++){
            if(freq[i] > 0){
                return freq[i]; //freq of lexicographically smallest char in the word
            }
        }
        return 1;
    }
    
    public int[] NumSmallerByFrequency(string[] queries, string[] words) {
        
        //steps:
        //find the frequency of lexicographically smallest char for each of the queries string
        //find the frequency of lexicographically smallest char for each of the words string
        //sort words array based on this frequency
        //for each query, binary search on words on words array to find freq. > freq of query string
        
        int n = words.Length;
        int[] freqWords = new int[n]; //stores the freq of lexicographically smallest character in words
        
        for(int i = 0; i<n; i++){                           //O(n*m), n = words.Length
            freqWords[i] = findFreqLexSmallest(words[i]);   
        }
        
        Array.Sort(freqWords);                              //O((n*m)log(n*m))
        
        int q = queries.Length;
        int[] freqQueries = new int[q];
        
        for(int i = 0; i<q; i++){                           //O(q*m), q = queries.Length 
            freqQueries[i] = findFreqLexSmallest(queries[i]);
        }
        
        int[] ans = new int[q];
        
        for(int i = 0; i<q; i++){                           //O(q*logn)
            int low = 0;
            int high = n-1;
            
            while(low <= high){
                int mid = low + (high-low)/2;
                if(freqWords[mid] > freqQueries[i]){
                    ans[i] = n-mid;
                    high = mid-1;
                }else{
                    low = mid+1;
                }
            }
        }
        
        return ans;
        
        /*
            n = words.Length
            q = queries.Length
            m = length of longest string
            TC = (n*m) + (n*m log(n*m) + (q*m) + qlogn = O(n*m log(n*m))
            SC = O(n+2q) = O(n+q)
        */
    }
}