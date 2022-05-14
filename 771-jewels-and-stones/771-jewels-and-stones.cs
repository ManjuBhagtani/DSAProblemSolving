public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        HashSet<char> jewelSet = new HashSet<char>();
        
        int j = jewels.Length;
        
        for(int i = 0; i<j; i++){
            jewelSet.Add(jewels[i]);
        }
        
        int s = stones.Length;
        int stonesThatAreJewels = 0;
        
        for(int i = 0; i<s; i++){
            if(jewelSet.Contains(stones[i])){
                stonesThatAreJewels++;
            }
        }
        
        return stonesThatAreJewels;
        
        /*
            TC = O(jewels.Length + stones.Length)
            SC = O(jewels.Length)
        */
    }
}