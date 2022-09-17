public class Solution {
    public int FirstUniqChar(string s) {
        int n = s.Length;
        
        int[] occurrence = new int[26]; //stores position at which any character appears in the string.
        //initial values = -1 -> indicates that a char doesn't appear in the string
        //value = 0 to n-1 -> character appears in the string
        //value = -2 -> character appears more than once
        
        for(int i = 0; i<26; i++){
            occurrence[i] = -1;
        }
        
        for(int i = 0; i<n; i++){
            if(occurrence[s[i]-'a'] != -1){
                occurrence[s[i]-'a'] = -2;
                continue;
            }
            occurrence[s[i]-'a'] = i;
        }
        
        int minIndex = n;
        
        for(int i = 0; i<26; i++){
            if(occurrence[i] >= 0){
                minIndex = Math.Min(minIndex, occurrence[i]);
            }
        }
        
        if(minIndex == n){
            return -1;
        }
        return minIndex;
    }
}

/*
    k = length of alphabet
    TC = O(n + k)
    SC = O(k)
*/