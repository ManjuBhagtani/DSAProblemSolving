/*

A string is good if there are no repeated characters.

Given a string s​​​​​, return the number of good substrings of length three in s​​​​​​.

Note that if there are multiple occurrences of the same substring, every occurrence should be counted.

A substring is a contiguous sequence of characters in a string.

Example 1:

Input: s = "xyzzaz"
Output: 1
Explanation: There are 4 substrings of size 3: "xyz", "yzz", "zza", and "zaz". 
The only good substring of length 3 is "xyz".


Example 2:

Input: s = "aababcabc"
Output: 4
Explanation: There are 7 substrings of size 3: "aab", "aba", "bab", "abc", "bca", "cab", and "abc".
The good substrings are "abc", "bca", "cab", and "abc".
 

Constraints:

1 <= s.length <= 100
s​​​​​​ consists of lowercase English letters.

*/

public class Solution {
    public int CountGoodSubstrings(string s) {
        
        //Generalized solution for any window of size k. Replace 3 by k everywhere.
        int count = 0;
        
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        //process the first window of size 3
        for(int i = 0; i<Math.Min(3, s.Length); i++){
            if(map.ContainsKey(s[i])){
                map[s[i]]++;
            }else{
                map.Add(s[i], 1);
            }
        }
        
        if(map.Count == 3){
            count++;
        }
        
        //process all subsequent windows of size 3
        for(int i = 3; i<s.Length; i++){
            int removeIndex = i-3;
            int addIndex = i;
            map[s[removeIndex]]--;
            if(map[s[removeIndex]] == 0){
                map.Remove(s[removeIndex]);
            }
            if(map.ContainsKey(s[addIndex])){
                map[s[addIndex]]++;
            }else{
                map.Add(s[addIndex], 1);
            }
            
            if(map.Count == 3){
                count++;
            }
        }
        
        return count;
    }
}

/*
	Iterations = 3 + (N-3) = N
	TC = O(N)
	SC = O(K). Here K = 3.
	SC = O(1)
*/