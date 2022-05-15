public class Solution {
    public int CountPoints(string rings) {
        int n = rings.Length;
        
        //key = rod no, value = set of distinct colored rings on this rod
        Dictionary<int, HashSet<char>> rodRingMap = new Dictionary<int, HashSet<char>>();
        
        int ans = 0;
        
        for(int i = 0; i<n-1; i+= 2){
            if(!rodRingMap.ContainsKey(rings[i+1])){
                HashSet<char> ringsOnThisRod = new HashSet<char>();
                ringsOnThisRod.Add(rings[i]);
                rodRingMap.Add(rings[i+1], ringsOnThisRod);
            }else{
                HashSet<char> ringsOnThisRod = rodRingMap[rings[i+1]];
                if(ringsOnThisRod.Count == 3){
                    continue;
                }else{
                    ringsOnThisRod.Add(rings[i]);
                    if(ringsOnThisRod.Count == 3){
                        ans++;
                    }
                } 
                rodRingMap[rings[i+1]] = ringsOnThisRod;
            }
        }
        return ans;
        
        /*
            TC = O(N)
            SC = O(N)
        */
    }
}
