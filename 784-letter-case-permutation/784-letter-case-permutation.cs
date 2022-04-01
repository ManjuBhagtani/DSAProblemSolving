public class Solution {
    
    public bool checkBit(int n, int i){
        if(((n>>i)&1) == 1){
            return true;
        }
        return false;
    }
    
    public IList<string> LetterCasePermutation(string s) {     
        int n = s.Length;
        List<int> positionsHavingLetters = new List<int>();
        
        for(int i = 0; i<n; i++){
            if(Char.IsLetter(s[i])){
                positionsHavingLetters.Add(i);
            }
        }
        
        int lettersInS = positionsHavingLetters.Count;
        
        List<string> ans = new List<string>();
        
        StringBuilder sb = new StringBuilder(s);
        
        int bitDiffInUpperAndLowercase = Math.Abs('a'-'A');
        
        int possibleStrings = 1<<lettersInS;
        
        for(int i = 0; i<possibleStrings; i++){         //O(2^n)
            for(int j = 0; j<lettersInS; j++){          //O(n)
                if(checkBit(i, j)){
                    sb[positionsHavingLetters[j]] = (char)(sb[positionsHavingLetters[j]] ^ bitDiffInUpperAndLowercase);
                }
            }
            ans.Add(sb.ToString());
            sb = new StringBuilder(s);
        }
        return ans;
        
        /*
            TC = O(2^n * n)
            SC = O(n) for the StringBuilder + O(n) for storing positions having letters
               = O(n)
        */
    }
}

