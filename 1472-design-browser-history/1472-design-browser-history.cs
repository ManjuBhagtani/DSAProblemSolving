class Node{
    public string val;
    public Node prev;
    public Node next;
    public Node(string page){
        val = page;
        prev = null;
        next = null;
    }
}
public class BrowserHistory {
    Node head = null;
    Node current = null;
    
    public BrowserHistory(string homepage) {
        head = new Node(homepage);
        current = head;
    }
    
    public void Visit(string url) {
        Node newNode = new Node(url);
        current.next = newNode;
        newNode.prev = current;
        current = newNode;
    }
    
    public string Back(int steps) {
        while(steps > 0 && current.prev != null){
            current = current.prev;
            steps--;
        }
        return current.val;
    }
    
    public string Forward(int steps) {
        while(steps > 0 && current.next != null){
            current = current.next;
            steps--;
        }
        return current.val;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */

//Add at back
//access elemnt from back
//access ith element after current element
//remove elements after ith element and add new one