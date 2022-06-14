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
    public IList<IList<int>> LevelOrder(Node root) {
        IList<IList<int>> ans = new List<IList<int>>();
        
        if(root == null){
            return ans;
        }
        
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root);
        
        while(q.Count > 0){
            int sz = q.Count;
            List<int> level = new List<int>();
            for(int i = 1; i<=sz; i++){
                Node first = q.Dequeue();
                level.Add(first.val);
                IList<Node> children = first.children;
                int c= children.Count;
                for(int j = 0; j<c; j++){
                    q.Enqueue(children[j]);
                }
            }
            ans.Add(level);
        }
        
        return ans;
        
        /*
            TC = O(n)
            SC = O(n)
        */
    }
}