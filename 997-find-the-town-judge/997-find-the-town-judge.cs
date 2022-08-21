class Graph{
    int V;
    HashSet<int>[] adj;
    
    public Graph(int v){
        V = v;
        adj  = new HashSet<int>[v];
        
        for(int i = 0; i<v; i++){
            adj[i] = new HashSet<int>();
        }
    }
    
    public void addEdge(int u, int v){
        adj[u].Add(v);
    }
    
    public int findJudge(){
        //judge trusts nobody, so their adj list length must be 0
        //check how many nodes have adj list length = 0;
        //if more than 1 person trusts nobody, then we cannot determine ans
        int count = 0;
        int judge = -1;
        for(int i = 1; i<V; i++){ //O(V)
            if(adj[i].Count == 0){
                count++;
                judge = i;
                if(count > 1){
                    return -1;
                }
            }
        }
        
        //exactly 1 person trusts nobody.
        //check if everyone else trusts this person
        //this person must be there in adj list of everyone
        for(int i = 1; i<V; i++){ //O(V)
            if(i != judge){
                if(!adj[i].Contains(judge)){
                    return -1;
                }
            }
        }
        
        return judge;
    }
    
}

public class Solution {
    public int FindJudge(int n, int[][] trust) {
        Graph g = new Graph(n+1);
        
        int e = trust.Length;
        
        for(int i = 0; i<e; i++){
            g.addEdge(trust[i][0], trust[i][1]);
        }
        
        return g.findJudge();
    }
}

/*
    TC = O(V+E) for constructing graph + O(2V) = O(V+E) = O(n+e)
    SC = O(V+E) = O(n+e)
*/