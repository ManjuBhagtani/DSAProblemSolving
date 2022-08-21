class Graph{
    int V;
    List<int>[] adj;
    
    public Graph(int v){
        V = v;
        adj = new List<int>[v];
        
        for(int i = 0; i<v; i++){
            adj[i] = new List<int>();
        }
    }
    
    public void addEdge(int u, int v){
        adj[u].Add(v);
        adj[v].Add(u);
    }
    
    public void dfs(int v, bool[] visited, int dest){
        visited[v] = true;
        
        if(v == dest){
            return;
        }
        
        foreach(int u in adj[v]){
            if(!visited[u]){
                dfs(u, visited, dest);
                if(visited[dest]){
                    return;
                }
            }
        }
    }
    public bool dfsHelper(int src, int dest){
        bool[] visited = new bool[V];
        
        dfs(src, visited, dest);
        
        return visited[dest];
        
    }
}
public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        //dfs
        Graph g = new Graph(n);
        
        int e = edges.Length;
        
        for(int i = 0; i<e; i++){
            g.addEdge(edges[i][0], edges[i][1]);
        }
        
        return g.dfsHelper(source, destination);    
        
    }
}

/*
    TC = O(V+E) = O(n+e) for dfs
    SC = O(V+E) for constructing graph + O(V) for visited array
       = O(V+E) = O(n+e) 
*/