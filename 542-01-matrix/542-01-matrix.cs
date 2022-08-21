public class Solution {
    
    public bool isValid(int x, int y, int n, int m, int[][] mat, bool[][] visited){
        if(x >= 0 && x < n && y >= 0 && y < m && mat[x][y] != 0 && !visited[x][y]){
            return true;
        }
        return false;
    }
    
    public int[][] bfs(int[][] mat, int n, int m){
        bool[][] visited = new bool[n][];
        int[][] dist = new int[n][];
        for(int i = 0; i<n; i++){
            visited[i] = new bool[m];
            dist[i] = new int[m];
        }
        Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
        
        for(int i = 0; i<n; i++){           //O(n)
            for(int j = 0; j<m; j++){       //O(m)
                if(mat[i][j] == 0){
                    Tuple<int, int> t = new Tuple<int, int>(i, j);
                    q.Enqueue(t);
                    visited[i][j] = true;
                    dist[i][j] = 0;
                }
            }
        }
        
        int[] dx = {-1, 0, 1, 0}; //T L B R
        int[] dy = {0, 1, 0, -1}; // T L B R
        
        while(q.Count > 0){
            Tuple<int, int> front = q.Dequeue();
            for(int i = 0; i<4; i++){
                int newI = front.Item1 + dx[i];
                int newJ = front.Item2 + dy[i];
                
                if(isValid(newI, newJ, n, m, mat, visited)){
                    q.Enqueue(new Tuple<int, int>(newI, newJ));
                    visited[newI][newJ] = true;
                    dist[newI][newJ] = dist[front.Item1][front.Item2] + 1;
                }
            }
        }
        
        return dist;
    }
    
    public int[][] UpdateMatrix(int[][] mat) {
        int n = mat.Length;
        int m = mat[0].Length;
        
        //multisource bfs
        return bfs(mat, n, m);
        
    }
}

/*
    TC = O(V+E) , V = nm , E = 2nm 
       = O(nm + 2nm)
       = O(nm)
    SC = O(nm) - dist & visited array
*/