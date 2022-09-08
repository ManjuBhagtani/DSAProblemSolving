class Graph{
    int V;
    List<int>[] adj;
    int[] indegree;
    
    public Graph(int v){
        V = v;
        adj = new List<int>[v];
        indegree = new int[v];
        
        for(int i = 0; i<v; i++){
            adj[i] = new List<int>();
        }
    }
    
    public void addEdge(int u, int v){
        adj[u].Add(v);
        indegree[v]++;
    }
    
    public bool topologicalSort(){
        Queue<int> q = new Queue<int>();
        
        for(int i = 0; i<V; i++){
            if(indegree[i] == 0){
                q.Enqueue(i);
            }
        }
        
        int coursesCompleted = 0;
        
        while(q.Count > 0){
            int front = q.Dequeue();
            coursesCompleted++;
            
            foreach(int nbr in adj[front]){
                indegree[nbr]--;
                if(indegree[nbr] == 0){
                    q.Enqueue(nbr);
                }
            }
        }
        
        if(coursesCompleted == V){
            return true;
        }
        return false;
    }
}
public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Graph g = new Graph(numCourses);
        
        int e = prerequisites.Length;
        
        for(int i = 0; i<e; i++){
            g.addEdge(prerequisites[i][0], prerequisites[i][1]);
        }
        
        return g.topologicalSort();
        
    }
}

/*
    TC = O(V+E)
    SC = O(V+E)
*/