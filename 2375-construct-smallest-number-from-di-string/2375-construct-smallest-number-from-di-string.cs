public class Solution {
    public string SmallestNumber(string pattern) {
        Stack<int> stack = new Stack<int>();
        
        int n = pattern.Length;
        
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i<=n; i++){
            stack.Push(i+1);
            if(i == n || pattern[i] == 'I'){
                while(stack.Count > 0){
                    sb.Append((char)(stack.Pop() + '0'));
                }
            }
        }
        
        return sb.ToString();
    }
}

/*
    TC = O(n)
    SC = O(n)
*/

//https://leetcode.com/problems/construct-smallest-number-from-di-string/discuss/2564035/Intuition
//https://leetcode.com/problems/construct-smallest-number-from-di-string/discuss/2557946/C%2B%2BororStackororEasy-to-Understand