/*

Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.

Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.

Example 1:

Input: s = "abciiidef", k = 3
Output: 3
Explanation: The substring "iii" contains 3 vowel letters.


Example 2:

Input: s = "aeiou", k = 2
Output: 2
Explanation: Any substring of length 2 contains 2 vowels.


Example 3:

Input: s = "leetcode", k = 3
Output: 2
Explanation: "lee", "eet" and "ode" contain 2 vowels.
 

Constraints:

1 <= s.length <= 10^5
s consists of lowercase English letters.
1 <= k <= s.length

*/

public class Solution {
    
    public bool isVowel(char c){
        if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'){
            return true;
        }
        
        return false;
    }
    
    public int MaxVowels(string s, int k) {
        int n = s.Length;
        
        int maxVowels = 0;
        
        int vowelsInCurrentWindow = 0;
        
        //process the first window of size k
        for(int i = 0; i<k; i++){
            if(isVowel(s[i])){
                vowelsInCurrentWindow++;
            }
        }
        
        maxVowels = vowelsInCurrentWindow;
        
        //process the subsequent windows of size k
        for(int i = k; i<n; i++){
            int removeIndex = i-k;
            int addIndex = i;
            
            if(isVowel(s[removeIndex])){
                vowelsInCurrentWindow--;
            }
            if(isVowel(s[addIndex])){
                vowelsInCurrentWindow++;
            }
            
            maxVowels = Math.Max(maxVowels, vowelsInCurrentWindow);
            if(maxVowels == k){
                return maxVowels;
            }
        }
        
        return maxVowels;
    }
}

/*
	TC = O(N)
	SC = O(1)
*/