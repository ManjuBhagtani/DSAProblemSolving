public class Solution {
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) {
        int[,] adj = new int[numCourses, numCourses];
        for(int i = 0; i<numCourses; i++){
            for(int j = 0; j<numCourses; j++){
                adj[i,j] = int.MaxValue;
            }
        }
        
        int noOfPrereq = prerequisites.Length;
        
        for(int i = 0; i<noOfPrereq; i++){
            adj[prerequisites[i][0], prerequisites[i][1]] = 1;
        }
        
        for(int k = 0; k<numCourses; k++){
            for(int i = 0; i<numCourses; i++){
                for(int j = 0; j<numCourses; j++){
                    if(k == i || k == j || i == j){
                        continue;
                    }
                    if(adj[i,k] != int.MaxValue && adj[k,j] != int.MaxValue)
                        adj[i,j] = Math.Min(adj[i,j], adj[i,k] + adj[k,j]);
                }
            }
        }
        
        int q = queries.Length;
        IList<bool> ans = new List<bool>(q);
        foreach(int[] query in queries){
            if(adj[query[0], query[1]] != int.MaxValue){
                ans.Add(true);
            }else{
                ans.Add(false);
            }
        }
        
        return ans;
    }
}

/*
    TC = O(n^3 + q)
    SC = O(n^3)
*/