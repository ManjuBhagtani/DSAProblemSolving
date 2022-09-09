class Graph{
    int V;
    List<int>[] adj;
    int[] quiet;
    
    public Graph(int v, int[] quietness){
        V = v;
        adj = new List<int>[v];
        quiet = quietness;
        
        for(int i = 0; i<v; i++){
            adj[i] = new List<int>();
        }
    }
    
    public void addEdge(int u, int v){
        adj[u].Add(v);
    }
    
    public void dfs(int v, bool[] visited, int[] ans){
        visited[v] = true;
        ans[v] = v;
        
        foreach(int nbr in adj[v]){
            if(!visited[nbr]){
                dfs(nbr, visited, ans);
                if(quiet[ans[nbr]] < quiet[v]){
                    ans[v] = ans[nbr];
                }
            }else{
                if(quiet[ans[nbr]] < quiet[ans[v]]){
                    ans[v] = ans[nbr]; 
                }
            }
        }
    }
    
    public int[] dfsHelper(){
        int[] ans = new int[V];
        bool[] visited = new bool[V];
        
        for(int i = 0; i<V; i++){
            if(!visited[i]){
                dfs(i, visited, ans);
            }
        }
        
        return ans;
    }
}
public class Solution {
    public int[] LoudAndRich(int[][] richer, int[] quiet) {
        int noOfPeople = quiet.Length;
        
        Graph g = new Graph(noOfPeople, quiet);
        
        int richerLength = richer.Length;
        
        for(int i = 0; i<richerLength; i++){
            g.addEdge(richer[i][1], richer[i][0]);
        }
        
        return g.dfsHelper();
    }
}

/*
    TC = O(V+E) for DFS
    SC = O(V+E) to construct graph + 
         O(V) for storing quite array +
         O(V) for DFS recursion stack
       = O(V+E)
         
    
*/