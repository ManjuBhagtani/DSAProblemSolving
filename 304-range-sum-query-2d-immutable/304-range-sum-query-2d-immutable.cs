public class NumMatrix {
    int[][] mat;
    int[,] prefixSum;
    
    public void calcPrefixSum(){
        int n = mat.Length;
        int m = mat[0].Length;
        prefixSum = new int[n,m];
        for(int i = 0; i<n; i++){                       //O(n)
            int sum = 0;
            for(int j = 0; j<m; j++){                   //O(m)
                sum += mat[i][j];
                int currentVal = sum;
                if(i > 0){
                    currentVal += prefixSum[i-1,j];
                }
                prefixSum[i,j] = currentVal;
            }
        }
    }
    
    public NumMatrix(int[][] matrix) {
        mat = matrix;
        calcPrefixSum();
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        //we have pre calculated prefix sum matrix in single iteration
        
        //find submatrix sum in O(1)
        int ans = prefixSum[row2,col2];
        if(col1 > 0){
            ans -= prefixSum[row2,col1-1];
        }
        if(row1 > 0){
            ans -= prefixSum[row1-1,col2];
        }
        if(row1 > 0 && col1 > 0){
            ans += prefixSum[row1-1,col1-1];
        }
        
        return ans;
        /*
            TC = O(n*m) + O(Q)
            SC = O(n*m)
        */
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */