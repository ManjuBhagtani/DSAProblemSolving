public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        int n = words.Length;
        
        string[] morseCode = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        
        HashSet<string> hs = new HashSet<string>();
        
        for(int i = 0; i<n; i++){
            StringBuilder code = new StringBuilder("");
            for(int j = 0; j<words[i].Length; j++){
                code.Append(morseCode[words[i][j]-'a']);
            }
            hs.Add(code.ToString());
        }
        
        return hs.Count;
        
        /*
            m  = length of each word 
            TC = O(sum of lengths of all words) = O(m*n)
            SC = O(n*m)
        */
    }
}