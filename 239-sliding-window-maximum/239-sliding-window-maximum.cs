class Node{
    public int val;
    public Node next;
    public Node prev;
    public Node(int v){
        val = v;
        next = null;
        prev = null;
    }
}

class DoublyEndedQueue{
    public Node head;
    public Node tail;
    public int size;
        
    public DoublyEndedQueue(){
        head = null;
        tail = null;
        size = 0;
    }
    
    public void addToFront(int val){
        Node newNode = new Node(val);
        if(head == null){
            head = newNode;
            tail = newNode;
        }else{
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }  
        size++;
    }
    
    public void addToTail(int val){
        Node newNode = new Node(val);
        if(head == null){
            head = newNode;
            tail = newNode;
        }else{
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }
        size++;
    }
    
    public void removeFromFront(){
        if(head == null){
            return;
        }
        if(head == tail){
            head = null;
            tail = null;
        }else{
            Node temp = head;
            head = head.next;
            head.prev = null;
            temp = null;
        }
        size--;
    }
    
    public void removeFromBack(){
        if(tail == null){
            return;
        }
        if(head == tail){
            head = null;
            tail = null;
        }else{
            Node temp = tail;
            tail = tail.prev;
            tail.next = null;
            temp = null;
        }
        size--;
    }
}
public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        
        //no. of sliding windows of length k = n-k+1
        int[] ans = new int[n-k+1];
        int ansIterator = 0;
        
        DoublyEndedQueue CL = new DoublyEndedQueue();
        
        for(int i = 0; i<k; i++){
            while(CL.size > 0 && nums[CL.tail.val] <= nums[i]){
                CL.removeFromBack();
            }
            CL.addToTail(i);
        }
        ans[ansIterator++] = nums[CL.head.val];
        
        int L = 1;
        int R = k;
        
        while(R < n){
            if(CL.size > 0 && CL.head.val == L-1){
                CL.removeFromFront();
            }
            while(CL.size > 0 && nums[CL.tail.val] <= nums[R]){
                CL.removeFromBack();
            }
            CL.addToTail(R);
            ans[ansIterator++] = nums[CL.head.val];
            L++;
            R++;
        }
        
        return ans;
    }
}

/*
    TC = O(n)
    SC = O(k)
*/