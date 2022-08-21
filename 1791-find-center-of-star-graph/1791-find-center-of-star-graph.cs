public class Solution {
    public int FindCenter(int[][] edges) {
        //Approach1 - 
        //int noOfEdges = edges.Length;
        
        //if there are n-1 edges, then the graph has n nodes - from 1 to n
        // int[] freq = new int[noOfEdges+2];
        
//         for(int i = 0; i<noOfEdges; i++){
//             freq[edges[i][0]]++;
//             if(freq[edges[i][0]] == noOfEdges){
//                 return edges[i][0];
//             }
//             freq[edges[i][1]]++;
//             if(freq[edges[i][1]] == noOfEdges){
//                 return edges[i][1];
//             }
//         }
        
//         return 1;
        
        //Approach 2 - the center has an edge with every other node, so all edges have the center node.
        //center node must be edges[0][0] or edges[0][1]
        int node1 = edges[0][0];
        int node2 = edges[0][1];
        
        if(edges[1][0] == node1 || edges[1][1] == node1){
            return node1;
        }else{
            return node2;
        }
        
        /*
            TC = O(1)
            SC = O(1)
        */
    }
}