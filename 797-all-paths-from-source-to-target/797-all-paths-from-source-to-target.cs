public class Solution {
    IList<IList<int>> ans;
    IList<int> path;
    bool[] visited;
    int n;
    
    public void dfs(int v, int[][] graph){
        visited[v] = true;
        path.Add(v);
        if(v == n-1){
            ans.Add(new List<int>(path));
            visited[v] = false;
            path.RemoveAt(path.Count-1);
            return;
        }
        
        foreach(int nbr in graph[v]){
            if(!visited[nbr]){
                dfs(nbr, graph);
            }
        }
        visited[v] = false;
        path.RemoveAt(path.Count-1);
    }
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        ans = new List<IList<int>>();
        path = new List<int>();
        n = graph.Length;
        visited = new bool[n];
        
        dfs(0, graph);
        
        return ans;
    }
}

/*
    TC = O(V+E) 
    SC = O(V) for path
*/