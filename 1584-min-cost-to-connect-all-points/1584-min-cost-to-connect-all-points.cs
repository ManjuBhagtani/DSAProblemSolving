
public class Solution {
    public void swap(List<Tuple<int, int, int>> minHeap,int i, int j){
        Tuple<int, int, int> temp = minHeap[i];
        minHeap[i] = minHeap[j];
        minHeap[j] = temp;
    }
    
    public void insertToMinHeap(List<Tuple<int, int, int>> minHeap, Tuple<int, int, int> entry){
        minHeap.Add(entry);
        int n = minHeap.Count;
        int i = n-1;
        while(i > 0 && minHeap[(i-1)/2].Item1 > minHeap[i].Item1){
            swap(minHeap, i, (i-1)/2);
            i = (i-1)/2;
        }
    }
    
    public void minHeapify(List<Tuple<int, int, int>> minHeap, int i){
        int n = minHeap.Count;
        int smallest = i;
        int l = 2*i + 1;
        int r = l + 1;
        if(l < n && minHeap[l].Item1 < minHeap[smallest].Item1){
            smallest = l;
        }
        if(r < n && minHeap[r].Item1 < minHeap[smallest].Item1){
            smallest = r;
        }
        if(smallest != i){
            swap(minHeap, i, smallest);
            minHeapify(minHeap, smallest);
        }
    }
    public void deleteMinFromMinHeap(List<Tuple<int, int, int>> minHeap){
        int n = minHeap.Count;
        swap(minHeap, 0, n-1);
        minHeap.RemoveAt(n-1);
        minHeapify(minHeap, 0);
    }
    public int prims(int[,] graph, int n){
        bool[] visited = new bool[n];
        List<Tuple<int, int, int>> minHeap = new List<Tuple<int, int, int>>();
        int sum = 0;
        
        visited[0] = true;
        for(int j = 1; j<n; j++){           //O(n)
            if(graph[0, j] != 0){
                insertToMinHeap(minHeap, new Tuple<int, int, int>(graph[0, j], 0, j)); //O(log n)
            }
        }
        
        while(minHeap.Count > 0){
            Tuple<int, int, int> closest = minHeap[0];
            deleteMinFromMinHeap(minHeap);  //O(log n)
            int wt = closest.Item1;
            int u = closest.Item2;
            int v = closest.Item3;
            
            if(visited[v]){
                continue;
            }else{
                sum += wt;
                visited[v] = true;
                for(int i = 0; i<n; i++){   //O(n)
                    if(!visited[i] && graph[v,i] != 0){
                        insertToMinHeap(minHeap, new Tuple<int, int, int>(graph[v, i], v, i)); //O(n)
                    }
                }
            }
            
        }
        
        return sum;
    }
    public int MinCostConnectPoints(int[][] points) {
        int n = points.Length;
        
        //construct adj matrix
        int[,] graph = new int[n,n];
        
        for(int i = 0; i<n; i++){           //O(n)
            for(int j = 0; j<n; j++){       //O(n)
                if(i != j){
                    graph[i, j] = Math.Abs(points[i][0]-points[j][0]) + Math.Abs(points[i][1]-points[j][1]);
                }
            }
        }
        //we have the manhattan distance of all points from each other now
        
        //Prims algo
        return prims(graph, n);
    }
}