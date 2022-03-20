public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        //Rows and columns are sorted in increasing order
        int n = matrix.Length;
        int m = matrix[0].Length; 
        int i = 0;
        int j = m-1; //start from top right corner
        
        while(i<n && j>=0){ 
            if(matrix[i][j] == target){ //if top right corner == target
                return true;
            }
            if(matrix[i][j] > target){ //top right corner value > target. So all elements below current element > target. So, eliminate the column.
                j--;
            }else{ //top right corner value < target. So current row cannot have the target element. So, eliminate the row.
                i++;
            }
        }
        
        return false;
        
        /*
            TC = O(Max(n,m))
            SC = O(1)
        */
    }
}