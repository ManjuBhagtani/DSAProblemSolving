public class Solution {
    
    public bool isValid(int x, int y, int n, int m, bool[,] visited, int[][] land){
        if(x >= 0 && x < n && y >= 0 && y < m && !visited[x,y] && land[x][y] == 1){
            return true;
        }
        return false;
    }
    
    public int[] bfs(int x, int y, int[][] land, bool[,] visited, int n, int m){
        int[] farmland = new int[4];
        farmland[0] = x;
        farmland[1] = y;
        farmland[2] = x;
        farmland[3] = y;
        
        Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
        
        q.Enqueue(new Tuple<int, int>(x, y));
        visited[x,y] = true;
        
        int[] dx = {-1, 0, 1, 0};
        int[] dy = {0, 1, 0, -1};
            
        //since the farmland is rectangular, the last element to get out of queue is my bottom right
        
        while(q.Count > 0){
            Tuple<int, int> front = q.Dequeue();
            farmland[2] = front.Item1;
            farmland[3] = front.Item2;
            
            for(int i = 0; i<4; i++){
                int newX = front.Item1 + dx[i];
                int newY = front.Item2 + dy[i];
                if(isValid(newX, newY, n, m, visited, land)){
                    q.Enqueue(new Tuple<int, int>(newX, newY));
                    visited[newX, newY] = true;
                }
            }
        }
        
        return farmland;
    }
    
    public int[][] bfsHelper(int[][] land){
        int n = land.Length;
        int m = land[0].Length;
        bool[,] visited = new bool[n, m];
        
        int k = 0;
        
        List<int[]>  ansList = new List<int[]>();
        for(int i = 0; i<n; i++){
            for(int j = 0; j<m; j++){
                if(!visited[i, j] && land[i][j] == 1){
                    ansList.Add(bfs(i, j , land, visited, n, m));
                }
            }
        }
        
        int rows = ansList.Count;
        int[][] ans = new int[rows][];
        for(int i = 0; i<rows; i++){
            ans[i] = ansList[i];
        }
        
        return ans;
    }
    public int[][] FindFarmland(int[][] land) {
        return bfsHelper(land);
    }
}

/*
    TC = O(nm)
    SC = O(nm)
*/ 