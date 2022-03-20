public class Solution {
    public int NumSubmatrixSumTarget(int[][] matrix, int target) {
        //calculate the prefix sum matrix in single iteration - O(n*m)
        
        int n = matrix.Length;
        int m = matrix[0].Length;
        
        int[,] prefixSum = new int[n,m];
        
        for(int i = 0; i<n; i++){
            int sum = 0;
            for(int j = 0; j<m; j++){
                int currentVal = matrix[i][j];
                currentVal += sum;
                sum += matrix[i][j];
                if(i>0){
                    currentVal += prefixSum[i-1, j];
                }
                prefixSum[i,j] = currentVal;
            }
        }
        
        int ans = 0;
        
        //for every submatrix, check whether it's sum = target - O(n^2 * m^2)
        for(int a1 = 0; a1<n; a1++){
            for(int b1 = 0; b1<m; b1++){
                //We have now fixed the top left corner of submatrix = {a1, b1}
                for(int a2 = a1; a2<n; a2++){
                    for(int b2 = b1; b2<m; b2++){
                        //We have now fixed the bottom right corner of matrix = {a2,b2}
                        int submatrixSum = prefixSum[a2,b2];
                        if(b1 > 0){
                            submatrixSum -= prefixSum[a2,b1-1];
                        }
                        if(a1 > 0){
                            submatrixSum -= prefixSum[a1-1, b2];
                        }
                        
                        if(a1 > 0 && b1 > 0){
                            submatrixSum += prefixSum[a1-1,b1-1];
                        }
                        if(submatrixSum == target){
                            ans++;
                        }
                    }
                }
            }
        }
        
        return ans;
        
        /*
            TC = O(n^2 * m^2)
            SC = O(n*m)
        */
    }
}