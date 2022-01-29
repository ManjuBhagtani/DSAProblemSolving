/*

Given an array of strings words, return the first palindromic string in the array. If there is no such string, return an empty string "".

A string is palindromic if it reads the same forward and backward.

 
Example 1:

Input: words = ["abc","car","ada","racecar","cool"]
Output: "ada"
Explanation: The first string that is palindromic is "ada".
Note that "racecar" is also palindromic, but it is not the first.


Example 2:

Input: words = ["notapalindrome","racecar"]
Output: "racecar"
Explanation: The first and only string that is palindromic is "racecar".


Example 3:

Input: words = ["def","ghi"]
Output: ""
Explanation: There are no palindromic strings, so the empty string is returned.
 

Constraints:

1 <= words.length <= 100
1 <= words[i].length <= 100
words[i] consists only of lowercase English letters.

*/

public class Solution {
    public string FirstPalindrome(string[] words) {
        for(int i = 0; i<words.Length; i++){
            int left = 0;
            int right = words[i].Length-1;
	    //Two pointer approach
            while(left < right){
                if(words[i][left] == words[i][right]){
                    left++;
                    right--;
                }else{
                    break;
                }
            }
            if(left >= right){
                return words[i];
            }
        }
        return "";
    }
}

/*
	TC = O(Sum of lengths of all words in the array)
	SC = O(1)
*/