public class Solution {
    public IList<string> CellsInRange(string s) {
        int n = s.Length;
        
        char startCol = s[0];
        int startRow = s[1]-'0';
        char endCol = s[3];
        int endRow = s[4]-'0';
        
        int rowRange = endRow - startRow + 1;
        int colRange = endCol - startCol + 1;
        
        List<string> ans = new List<string>(rowRange*colRange);
        
        for(char j = startCol; j<=endCol; j++){
            for(int i = startRow; i<=endRow; i++){     
                ans.Add($"{Char.ToString(j)}{i}");
            }
        }
        
        return ans;
    }
}