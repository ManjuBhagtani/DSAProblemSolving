public class Solution {
    public bool CheckIfPangram(string sentence) {
        int n = sentence.Length;
        bool[] charOccurs = new bool[26];
        
        for(int i = 0; i<n; i++){
            charOccurs[sentence[i]-'a'] = true;
        }
        
        for(int i = 0; i<26; i++){
            if(charOccurs[i] == false){
                return false;
            }
        }
        
        return true;
        
        /*
            TC = O(n)
            SC = O(1)
        */
    }
}