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
        int[] temp = new int[size];
        int tempTop = -1;
        while(top >= 0){
            temp[++tempTop] = Pop();
        }
        while(k-- > 0 && tempTop >= 0){
            Push(temp[tempTop]+val);
            tempTop--;
        }
        while(tempTop >= 0){
            Push(temp[tempTop--]);
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