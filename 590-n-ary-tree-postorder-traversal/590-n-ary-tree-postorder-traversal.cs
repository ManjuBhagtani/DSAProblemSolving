/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    IList<int> postorder = new List<int>();
    
    public IList<int> Postorder(Node root) {
        if(root == null){
            return postorder;
        }
        IList<Node> children = root.children;
        
        foreach(Node child in children){
            Postorder(child);
        }
        
        postorder.Add(root.val);
        
        return postorder;
    }
}

/*
    TC = O(n)
    SC = O(h)
*/