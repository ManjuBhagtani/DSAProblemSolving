class Graph{
    int V;
    List<KeyValuePair<int, int>>[] l;
    
    public Graph(int v){
        V = v;
        l = new List<KeyValuePair<int, int>>[v];
        
        for(int i = 0; i<v; i++){
            l[i] = new List<KeyValuePair<int, int>>();
        }
    }
    
    public void addEdge(int u, int v, int wt){
        l[u].Add(new KeyValuePair<int, int>(v, wt));
    }
    
    public void swap(List<KeyValuePair<int, int>> A, int i, int j){
        KeyValuePair<int, int> temp = A[i];
        A[i] = A[j];
        A[j] = temp;
    }
    public void minHeapify(List<KeyValuePair<int, int>> A, int i){
        int smallest = i;
        int l = 2*i + 1;
        int r = l+1;
        
        //KeyValuePair<int, int> lPair = A[l];
        if(l < A.Count && A[l].Value < A[smallest].Value){
            smallest = l;
        }
        if(r < A.Count && A[r].Value < A[smallest].Value){
            smallest = r;
        }
        if(smallest != i){
            swap(A, i, smallest);
            minHeapify(A, smallest);
        }
    }
    
    public void buildMinHeap(List<KeyValuePair<int, int>> minHeap){
        int n = V;
        for(int i = (n-2)/2; i>=0; i--){
            minHeapify(minHeap, i);
        }
    }
    
    public int findMinTime(int src){
        int[] dist = new int[V];
        List<KeyValuePair<int, int>> minHeap = new List<KeyValuePair<int, int>>();
        
        for(int i = 0; i<V; i++){
            if(i != src){
                dist[i] = int.MaxValue;
                minHeap.Add(new KeyValuePair<int, int>(i, int.MaxValue));
            }else{
                dist[i] = 0;
                minHeap.Add(new KeyValuePair<int, int>(src, 0));
            }
        }
        
        buildMinHeap(minHeap);
        
        while(minHeap.Count > 0){
            KeyValuePair<int, int> u = minHeap[0];
            minHeap[0] = minHeap[minHeap.Count-1];          
            minHeap.RemoveAt(minHeap.Count-1);
            minHeapify(minHeap, 0);
            
            int node = u.Key;
            int distTillNow = u.Value;
            
            foreach(KeyValuePair<int, int> nbrPair in l[node]){
                int nbr = nbrPair.Key;
                int currentEdge = nbrPair.Value;
                
                if(distTillNow + currentEdge < dist[nbr]){
                    dist[nbr] = distTillNow + currentEdge;
                    for(int i = 0; i<minHeap.Count; i++){
                        if(minHeap[i].Key == nbr){
                            minHeap[i] = new KeyValuePair<int, int>(nbr, distTillNow + currentEdge);
                            int j = i;
                            while(j > 0 && minHeap[(j-1)/2].Value > minHeap[j].Value){
                                swap(minHeap, j, (j-1)/2);
                                j = (j-1)/2;
                            }
                            
                            break;
                        }
                    }
                }
            }
        }
        
        int maxDist = int.MinValue;
        for(int i = 0; i<V; i++){
            if(dist[i] == int.MaxValue){
                return -1;
            }
            maxDist = Math.Max(maxDist, dist[i]); 
        }
        
        return maxDist;
    }
}

public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        int edges = times.Length;
        
        Graph g = new Graph(n);
        
        for(int i = 0; i<edges; i++){
            g.addEdge(times[i][0]-1, times[i][1]-1, times[i][2]);
        }

        return g.findMinTime(k-1);
        
    }
}