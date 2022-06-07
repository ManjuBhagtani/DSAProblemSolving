public class RecentCounter {
    int count;
    Queue<int> q;
    public RecentCounter() {
        count = 0;
        q = new Queue<int>();
    }
    
    public int Ping(int t) {
        q.Enqueue(t);
        count++;
        
        int rangeStart = t-3000;
        
        while(rangeStart > 0 && q.Peek() < rangeStart){
            q.Dequeue();
            count--;
        }
        
        return count;
        
        /*
            TC = O(N) where N = no. of pings
            SC = O(1) since max queue size will be 3000
        */
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */