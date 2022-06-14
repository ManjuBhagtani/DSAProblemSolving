public class Solution {
    public int FindTheWinner(int n, int k) {
        Queue<int> q = new Queue<int>(n);
        
        for(int i = 1; i<=n; i++){
            q.Enqueue(i);
        }
        
        while(q.Count > 1){
            for(int i = 1; i<k; i++){
                q.Enqueue(q.Dequeue());
            }
            q.Dequeue();
        }
        
        return q.Dequeue();
    }
}