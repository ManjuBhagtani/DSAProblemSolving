/*

Given an n x n binary matrix image, flip the image horizontally, then invert it, and return the resulting image.

To flip an image horizontally means that each row of the image is reversed.

For example, flipping [1,1,0] horizontally results in [0,1,1].
To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0.

For example, inverting [0,1,1] results in [1,0,0].
 
Example 1:

Input: image = [[1,1,0],[1,0,1],[0,0,0]]
Output: [[1,0,0],[0,1,0],[1,1,1]]
Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]


Example 2:

Input: image = [[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
Output: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
Explanation: First reverse each row: [[0,0,1,1],[1,0,0,1],[1,1,1,0],[0,1,0,1]].
Then invert the image: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
 

Constraints:

n == image.length
n == image[i].length
1 <= n <= 20
images[i][j] is either 0 or 1.

*/

public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        for(int i = 0; i<image.Length; i++){
            
            //Reverse the row and flip
            int left = 0;
            int right = image[0].Length-1;
            
            while(left <= right){
                image[i][left] = 1 - image[i][left];
                
                //if left and right are pointing to same element, 
                //without this condition we end up flipping that element twice and 
                //swapping it with itself!
                if(left != right){
                    image[i][right] = 1 - image[i][right];

                    int temp = image[i][left];
                    image[i][left] = image[i][right];
                    image[i][right] = temp;               
                }
                left++;
                right--;
            }
        }
        return image;
    }
}

/* 	TC = O(N^2)
	SC = O(1)
*/