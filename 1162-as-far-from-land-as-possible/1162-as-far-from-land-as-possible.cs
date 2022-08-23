public class Solution {
    public bool isValid(int x, int y, int n, int[][] grid, bool[,] visited){
        if(x >= 0 && x < n && y >= 0 && y < n && grid[x][y] == 0 && !visited[x,y]){
            return true;
        }
        return false;
    }
    public int MaxDistance(int[][] grid) {
        int n = grid.Length;
        
        Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
        bool[,] visited = new bool[n,n];
        int[,] dist = new int[n,n];
        
        //multi source BFS
        //Put the sources in queue
        for(int i = 0; i<n; i++){
            for(int j = 0; j<n; j++){
                if(grid[i][j] == 1){
                    q.Enqueue(new Tuple<int, int>(i, j));
                    visited[i,j] = true;
                    dist[i, j] = 0;
                }
            }
        }
        
        int[] dx = {-1, 0, 1, 0};
        int[] dy = {0, 1, 0, -1};
        
        int maxDist = -1;
        
        while(q.Count > 0){
            Tuple<int, int> front  = q.Dequeue();
            for(int i = 0; i < 4; i++){
                int newI = front.Item1 + dx[i];
                int newJ = front.Item2 + dy[i];
                if(isValid(newI, newJ, n, grid, visited)){
                    q.Enqueue(new Tuple<int, int>(newI, newJ));
                    visited[newI, newJ] = true;
                    dist[newI, newJ] = dist[front.Item1, front.Item2] + 1;
                    maxDist = dist[newI, newJ]; 
                }
            }    
        }
        
        return maxDist;
    }
}

/*
    TC = O(V+E) = O(nn + 2nn) = O(3nn) = O(n^2) for BFS
    SC = O(V+E) for visited and dist array = O(n^2)
*/