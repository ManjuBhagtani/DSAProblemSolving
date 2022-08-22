public class Solution {
    public bool isValid(int x, int y, int n, int m, bool[,] visited, int[][] isWater){
        if(x >= 0 && x < n && y >= 0 && y < m && !visited[x,y] && isWater[x][y] == 0){
            return true;
        }
        return false;
    }
    
    public int[][] bfs(int[][] isWater, int n, int m){
        Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
        bool[,] visited = new bool[n,m];
        int[][] dist = new int[n][];
        
        for(int i = 0; i < n; i++){
            dist[i] = new int[m];
            for(int j = 0; j < m; j++){
                if(isWater[i][j] == 1){ //source nodes
                    q.Enqueue(new Tuple<int, int>(i, j));
                    visited[i,j] = true;
                    dist[i][j] = 0;
                }
            }
        }
        
        int[] dx = {-1, 0, 1, 0};
        int[] dy = {0, 1, 0, -1};
        
        while(q.Count > 0){
            Tuple<int, int> front = q.Dequeue();
            for(int i = 0; i < 4; i++){
                int newI = front.Item1 + dx[i];
                int newJ = front.Item2 + dy[i];
                
                if(isValid(newI, newJ, n, m, visited, isWater)){
                    q.Enqueue(new Tuple<int, int>(newI, newJ));
                    visited[newI, newJ] = true;
                    dist[newI][newJ] = dist[front.Item1][front.Item2] + 1;
                }
            }
        }
        
        return dist;
    }
    public int[][] HighestPeak(int[][] isWater) {
        //multisource bfs
        int n = isWater.Length;
        int m = isWater[0].Length;
        
        return bfs(isWater, n, m);
    }
}

/*
    TC = O(V+E) , V = nm, E = 2nm
       = O(3nm)
       = O(nm)
    SC = O(V+E) for dist and visited array
       = O(nm)
*/