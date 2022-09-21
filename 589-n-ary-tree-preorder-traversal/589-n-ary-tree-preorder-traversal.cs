/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    IList<int> pre = new List<int>();
    
    public IList<int> Preorder(Node root) {
        if(root == null){
            return pre;
        }
        pre.Add(root.val);
        foreach(Node child in root.children){
            Preorder(child);
        }
        return pre;
    }
}

/*
    TC = O(n)
    SC = O(h)
*/