public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int ans = 0;
        int l = 0;
        int r = 0;
        
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        while(r < n){
            if(!map.ContainsKey(s[r])){
                map.Add(s[r], r);
            }else{
                ans = Math.Max(ans, r-l);
                for(int i = l; i<map[s[r]]; i++){
                    map.Remove(s[i]);
                }
                l = map[s[r]]+1; 
                map[s[r]] = r;              
            }
            r++;
        }
        
        ans = Math.Max(ans, r-l);
        return ans;
        
        /*
            TC = O(n)
            SC = O(n)
        */
    }
}
