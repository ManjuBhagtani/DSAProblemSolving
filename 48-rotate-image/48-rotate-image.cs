public class Solution {
    
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        
        //Find Transpose
        for(int i = 1; i<n; i++){
            for(int j = 0; j<i; j++){
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
        
        //reverse the matrix obtained in step1
        
        
        for(int i = 0; i<n; i++){
            int left = 0;
            int right = n-1;
        
            while(left < right){
                //swap(matrix[i][left], matrix[i][right]);
                int temp = matrix[i][left];
                matrix[i][left] = matrix[i][right];
                matrix[i][right] = temp;
                left++;
                right--;
            }
        }
    }
}

//[[5,1,9,11],          5  2  13  15
//i=1   [2,4,8,10],    ->    1  4  3   14
//   [13,3,6,7],          9  8  6   12
//   [15,14,12,16]]       11 10 7   16
   
       
       