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
    public int MaxDepth(Node root) {
        if(root == null){
            return 0;
        }
        int maxDepth = 1;
        foreach(Node child in root.children){
            maxDepth = Math.Max(1+MaxDepth(child), maxDepth);
        }
        return maxDepth;
    }
}

/*
    TC = O(n)
    SC = O(h)
*/