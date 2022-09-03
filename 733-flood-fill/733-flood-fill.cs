public class Solution {
    
    public bool isValid(int x, int y, int n, int m, bool[, ] visited, int[][] image, int startColor){
        if(x >= 0 && x < n && y >= 0 && y < m && !visited[x, y] && image[x][y] == startColor){
            return true;
        }
        return false;
    }
    
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if(image[sr][sc] == color){
            return image;
        }
        
        int n = image.Length;
        int m = image[0].Length;
        
        int[][] ans = image;
        
        Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
        bool[, ] visited = new bool[n, m];
        
        int[] dx = {-1, 0, 1, 0};
        int[] dy = {0, 1, 0, -1};
        
        int startColor = image[sr][sc];
        
        q.Enqueue(new Tuple<int, int>(sr, sc));
        visited[sr, sc] = true;
        ans[sr][sc] = color;
        
        while(q.Count > 0){
            Tuple<int, int> front = q.Dequeue();
            
            for(int i = 0; i<4; i++){
                int newX = front.Item1 + dx[i];
                int newY = front.Item2 + dy[i];
                
                if(isValid(newX, newY, n, m, visited, image, startColor)){
                    q.Enqueue(new Tuple<int, int>(newX, newY));
                    visited[newX, newY] = true;
                    ans[newX][newY] = color;
                }
            }
            
        }
        
        return ans;
    }
}

/*
    TC = O(V+E) = O(nm + 2nm) = O(nm)
    SC = O(V) = O(nm)
*/