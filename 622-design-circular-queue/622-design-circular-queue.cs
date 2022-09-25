public class MyCircularQueue {

    int[] q;
    int front;
    int rear;
    int currSize;
    int qCapacity;
    
    public MyCircularQueue(int k) {
        q = new int[k];
        front = -1;
        rear = -1;
        currSize = 0;
        qCapacity = k;
    }
    
    public bool EnQueue(int value) {    //O(1)
        if(IsFull()){
            return false;
        }
        if(IsEmpty()){
            front = rear = 0;
            q[rear] = value;
            currSize++;
            return true;
        }
        rear++;
        rear %= qCapacity;
        q[rear] = value;
        currSize++;
        return true;
    }
    
    public bool DeQueue() {    //O(1)
        if(IsEmpty()){
            return false;
        }
        front = (front + 1) % qCapacity;
        currSize--;
        return true;
    }
    
    public int Front() {    //O(1)
        return IsEmpty() ? -1 : q[front];
    }
    
    public int Rear() {    //O(1)
        return IsEmpty() ? -1 : q[rear];
    }
        
    public bool IsEmpty() {    //O(1)
        return currSize == 0;
    }
    
    public bool IsFull() {    //O(1)
        return currSize == qCapacity;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */