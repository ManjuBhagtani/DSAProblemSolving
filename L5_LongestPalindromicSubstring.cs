/*

Given a string s, return the longest palindromic substring in s.

Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.


Example 2:

Input: s = "cbbd"
Output: "bb"
 

Constraints:

1 <= s.length <= 1000
s consist of only digits and English letters.

*/

public class Solution {
    
    public string expand(int i, int j, string s){
        StringBuilder expandedString = new StringBuilder("");
        bool isPalindrome = false;
        while(i>=0 && j<s.Length && s[i] == s[j]){		//O(N)
            isPalindrome = true;
            i--;
            j++;
        }
        if(isPalindrome){
            for(int k = i+1; k<j; k++){				//O(N)
                expandedString.Append(s[k]);
            }
        }
        return expandedString.ToString();
    }
    public string LongestPalindrome(string s) {
        int max = 1;
        string ans = "" + s[0];
        for(int i = 0; i<s.Length-1; i++){			//O(N)
           string oddLengthString = expand(i, i, s); 
           if(oddLengthString.Length > max){
               max = oddLengthString.Length;
               ans = oddLengthString;
           }
            
           string evenLengthString = expand(i, i+1, s); 
           if(evenLengthString.Length > max){
               max = evenLengthString.Length;
               ans = evenLengthString;
           }
        }
        
        return ans;
    }
}

/*
	TC = O(N) * 
	     (O(N)+O(N) for odd length substring
	      O(N)+O(N) for even length substring)
           = O(N^2)
	SC = O(N)
*/

//Same approach implemented differently

public class Solution2 {
    
    int start = 0;
    int end = 0;
    string _s;
    int n;
    
    public void expand(int i, int j){

        while(i>=0 && j<n && _s[i] == _s[j]){	//O(N)
            if(end-start < j-i){
                start = i;
                end = j;
            }
            i--;
            j++;
        }
    }
    public string LongestPalindrome(string s) {
        
        _s = s;
        
        n = s.Length;
        
        for(int i = 0; i<n-1; i++){ 		//O(N)
           expand(i, i); 
           expand(i, i+1); 
        }
        
        return s.Substring(start, end-start+1); //O(N)
    }
}

/*
	TC = O(N^2) + O(N)
           = O(N^2)

	SC = O(N)
*/