class Graph{
    int V;
    List<int>[] adj;
    int[] outdegree;
    
    public Graph(int v){
        V = v;
        adj = new List<int>[v];
        outdegree = new int[v];
        
        for(int i = 0; i<v; i++){
            adj[i] = new List<int>();
        }
    }
    
    public void addEdge(int u, int v){
        adj[u].Add(v);
        outdegree[v]++;
    }
    
    public List<int> topologicalSort(){
        Queue<int> q = new Queue<int>();
        List<int> ans = new List<int>();
        
        for(int i = 0; i<V; i++){
            if(outdegree[i] == 0){ //terminal node
                q.Enqueue(i);
            }
        }
        
        while(q.Count > 0){
            int front = q.Dequeue();
            ans.Add(front);
            
            foreach(int nbr in adj[front]){
                outdegree[nbr]--;
                if(outdegree[nbr] == 0){
                    q.Enqueue(nbr);
                }
            }
        }
        
        ans.Sort();
        
        return ans;
    }
}
public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph) {
        //construct reverse graph
        //store the outdegree of each node
        //put the nodes with 0 outdegree in queue - these are terminal nodes, so always safe
        //while q is no empty
        // front = q.dequeue
        // reduce the outdegree of adjacent nodes
        //if their outdegree == 0, they are now terminal nodes, so put them in q
        
        int noOfStates = graph.Length;
        Graph g = new Graph(noOfStates);
        
        for(int i = 0; i<noOfStates; i++){
            foreach(int nbr in graph[i]){
                g.addEdge(nbr, i);
            }
        }
        
        return g.topologicalSort();
    }
}

/*
    TC = O(V+E)
    SC = O(V+E) to construct graph +
         O(V) to store outdegree +
         O(V) for queue
       = O(V+E)
*/