public class Solution {
    
    public bool isValid(int x, int y, int n, int m, int[][] grid, bool[][] visited){
        if(x >= 0 && x < n && y >= 0 && y < m && grid[x][y] != 0 && grid[x][y] != 2 && !visited[x][y]){
            return true;
        }
        return false;
    }
    public int bfs(int[][] grid, int n, int m){
        bool[][] visited = new bool[n][];
        int[][] dist = new int[n][];
        
        for(int i = 0; i<n; i++){
            visited[i] = new bool[m];
            dist[i] = new int[m];
        }
        
        Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
        
        for(int i = 0; i<n; i++){
            for(int  j = 0; j<m; j++){
                if(grid[i][j] == 2){ //rotten orange
                    q.Enqueue(new Tuple<int, int>(i, j));
                }
            }
        }
        
        int[] dx = {-1, 0, 1, 0};
        int[] dy = {0, 1, 0, -1};
        
        int maxDist = 0;
        
        while(q.Count > 0){
            Tuple<int, int> front = q.Dequeue();

            for(int i = 0; i<4; i++){
                int newI = front.Item1 + dx[i];
                int newJ = front.Item2 + dy[i];
                if(isValid(newI, newJ, n, m, grid, visited)){
                    q.Enqueue(new Tuple<int, int>(newI, newJ));
                    visited[newI][newJ] = true;
                    dist[newI][newJ] = dist[front.Item1][front.Item2] + 1;
                    maxDist = Math.Max(maxDist, dist[newI][newJ]);
                }
            }
        }
        
        for(int i = 0; i<n; i++){
            for(int j = 0; j < m; j++){
                if(grid[i][j] == 1 && !visited[i][j]){
                    return -1;
                }
            }
        }
        return maxDist;
    }
    public int OrangesRotting(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        
        //multisource bfs
        return bfs(grid, n , m);
    }
}

/*
    TC  = O(V+E) = O(nm + 2nm) = O(nm)
    SC  = O(nm) for visited array and dist
*/