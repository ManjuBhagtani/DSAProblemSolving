class Graph{
    List<int>[] l;
    int V;
    
    public Graph(int v){
        V = v;
        l = new List<int>[v+1];
        for (int i = 0; i < V; i++){
            l[i] = new List<int>();
        }
    }
    
    public void AddEdge(int u, int v){
        l[u].Add(v);
    }

    public int minCostBFS(int src, int dest){
        Queue<int> q = new Queue<int>();
        bool[] visited = new bool[V];
        int[] dist = new int[V];
        
        q.Enqueue(src);
        visited[src] = true;
        dist[src] = 0;
        
        while(q.Count > 0){
            int f = q.Dequeue();
            foreach(int nbr in l[f]){
                if(!visited[nbr]){
                    q.Enqueue(nbr);
                    visited[nbr] = true;
                    dist[nbr] = dist[f]+1;
                }
            }
        }
        
        return dist[dest];
        
    }
}
public class Solution {
    public int SnakesAndLadders(int[][] board) {
        int len = board.Length;
        int n = len*len;
        int[] b = new int[n + 1];
        int k = 1;
        int flag = 0;
        for(int i = len-1; i>=0; i--){
            if(flag == 0){ 
                for(int j = 0; j<len; j++){
                    if(board[i][j] != -1){
                        int start = k;
                        int end = board[i][j];
                        b[start] = end-start;
                    }

                    k++;
                }
                flag = 1;
            }else{
                for(int j = len-1; j>=0; j--){
                    if(board[i][j] != -1){
                        int start = k;
                        int end = board[i][j];
                        b[start] = end-start;
                    }

                    k++;
                }
                flag = 0;
            }
        }
        
        Graph g = new Graph(n+1);

        for(int u = 1; u<n; u++){
           
            for(int dice = 1; dice <=6; dice++){
                int v = u+dice;
                if(v <= n){
                    v += b[v];
                }
                if(v <= n){
                    g.AddEdge(u, v);
                }
            }
        }       
        int ans = g.minCostBFS(1, n);
        if(ans == 0){
            return -1;
        }
        return ans;
    }
}