public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> ans = new List<int[]>();
        int n = intervals.Length;
        
        for(int i = 0; i<n; i++){
            if(newInterval[0] > intervals[i][1]){
                ans.Add(new int[2]{intervals[i][0], intervals[i][1]});
            }else if(newInterval[1] < intervals[i][0]){
                ans.Add(new int[2]{newInterval[0], newInterval[1]});
                for(int j = i; j<n; j++){
                    ans.Add(new int[2]{intervals[j][0], intervals[j][1]});
                }
                return ans.ToArray();
            }else{
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            }
        }
        
        ans.Add(new int[2]{newInterval[0], newInterval[1]});
        
        return ans.ToArray();
        
        /*
            TC = O(n)
            SC = O(n)
        */
    }
}