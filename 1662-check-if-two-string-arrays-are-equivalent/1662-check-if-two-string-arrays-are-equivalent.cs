public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        int n = word1.Length;
        int m = word2.Length;
        
        int p1 = 0;
        int p2 = 0;
        
        int i = 0; //iterates on array word1
        int j = 0; //iterates on array word2
        
        while(i<n && j<m){
            if(word1[i][p1] == word2[j][p2]){
                p1++;
                p2++;
                if(p1 == word1[i].Length){
                    p1 = 0;
                    i++;
                }
                if(p2 == word2[j].Length){
                    p2 = 0;
                    j++;
                }
            }else{
                return false;
            }
        }
        if(i != n || j != m){
            return false;
        }
        return true;
        
        /*
            sumWord1 = sum of lengths of all words in word1 array
            sumWord2 = sum of lengths of all words in word2 array
            TC = O(Min(sumWord1, sumWord2))
            SC = O(1)
        */
    }
}