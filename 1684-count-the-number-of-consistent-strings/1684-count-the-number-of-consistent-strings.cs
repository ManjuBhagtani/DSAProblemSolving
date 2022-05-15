public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        HashSet<char> allowedChars = new HashSet<char>();
        
        foreach(char c in allowed){
            allowedChars.Add(c);
        }
        
        int n = words.Length;
        
        int count = 0;
        
        for(int i = 0; i<n; i++){
            bool isConsistent = true;
            foreach(char c in words[i]){
                if(!allowedChars.Contains(c)){
                    isConsistent = false;
                    break;
                }
            }
            if(isConsistent){
                count++;
            }
        }
        
        return count;
        
        /*
            n = no. of words, m = length of each word
            k = no. of allowed characters
            TC = O(n*m)
            SC = O(k)
        */
    }
}