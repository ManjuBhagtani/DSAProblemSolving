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
    }
    
    public void dfs(int v, bool[] visited){
        visited[v] = true;
        
        foreach(int u in adj[v]){
            if(!visited[u]){
                dfs(u, visited);
            }
        }
    }
    
    public bool dfsHelper(int src){
        bool[] visited = new bool[V];
        
        dfs(0, visited);
        
        for(int i = 0; i<V; i++){
            if(!visited[i]){
                return false;
            }
        }
        
        return true;
        
    }
}
public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        int n = rooms.Count;
        
        Graph g = new Graph(n);
        
        for(int i = 0; i<n; i++){
            foreach(int u in rooms[i]){
                g.addEdge(i, u);
            }
        }
        
        return g.dfsHelper(0);
    }
}

/*
    TC = O(V+E) for constructing the graph + O(V+E) for DFS
       = O(V+E)
    SC = O(V+E) for constructing the graph + O(V) for visited array + O(V) for recursion stack
       = O(V+E)
*/