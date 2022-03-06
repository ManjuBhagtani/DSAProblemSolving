class Node{
    public int val;
    public Node next;
    public Node(int v){
        val = v;
        next = null;
    }
}

public class MinStack {

    Node head = null;
    int min = int.MaxValue;
    
    public MinStack() {
        
    }
    
    public void Push(int val) {
        Node newNode = new Node(val);
        if(head != null){
            newNode.next = head;           
        }
        head = newNode;
        if(val < min){
            min = val;
        }
    }
    
    public void Pop() {
        if(head.val == min){
            Node temp = head.next;
            min = int.MaxValue;
            while(temp != null){
                if(temp.val<min){
                    min = temp.val;
                }
                temp = temp.next;
            }
        }
        head = head.next;
    }
    
    public int Top() {
        return head.val;
    }
    
    public int GetMin() {
        return min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */