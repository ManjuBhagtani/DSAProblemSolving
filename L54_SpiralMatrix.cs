/*

Given an m x n matrix, return all elements of the matrix in spiral order.

Example 1:

Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,3,6,9,8,7,4,5]


Example 2:


Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
Output: [1,2,3,4,8,12,11,10,9,5,6,7]
 

Constraints:

m == matrix.length
n == matrix[i].length
1 <= m, n <= 10
-100 <= matrix[i][j] <= 100

*/

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> spiral = new List<int>();
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        
        int minRow = 0;
        int maxRow = rows-1;
        int minCol = 0;
        int maxCol = cols-1;
        
        int k = 0;
        
        while(k < rows*cols){ // k <= m*n
            for(int i = minCol; i <= maxCol ; i++){
                spiral.Add(matrix[minRow][i]);
                k++;
            }
            minRow++;
            
            if(k < rows*cols){
                for(int i = minRow; i <= maxRow; i++){
                    spiral.Add(matrix[i][maxCol]);
                    k++;
                }
                maxCol--;
            }
            
            if(k < rows*cols){
                for(int i = maxCol; i >= minCol; i--){
                    spiral.Add(matrix[maxRow][i]);
                    k++;
                }
                maxRow--;
            }
            
            if(k < rows*cols){
                for(int i = maxRow; i >= minRow; i--){
                    spiral.Add(matrix[i][minCol]);
                    k++;
                }
                minCol++;
            }
        }
        
        return spiral;
    }
}