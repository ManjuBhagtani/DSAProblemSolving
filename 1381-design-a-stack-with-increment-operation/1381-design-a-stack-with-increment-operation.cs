public class CustomStack {
    int[] stack;
    int top;
    int size;
    
    public CustomStack(int maxSize) {
        stack = new int[maxSize];
        top = -1;
        size = maxSize;
    }
    
    public void Push(int x) {
        if(top+1 < size){
            stack[++top] = x; 
        }
    }
    
    public int Pop() {
        int popped = -1;
        if(top >= 0){
            popped = stack[top];
            top--;
        }
        return popped;
    }
    
    public void Increment(int k, int val) {
        int min = Math.Min(k, top+1);
        for(int i = 0; i<min; i++){
            stack[i] += val;
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */
//[6,7] => [2,1]