//{ Driver Code Starts
//Initial Template for C#

using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                int[] arr = new int[2];

                string elements = Console.ReadLine().Trim();
                arr = Array.ConvertAll(elements.Split(), int.Parse);
                int N = arr[0];
                int M = arr[1];
                string s1 = Console.ReadLine().Trim();
                string s2 = Console.ReadLine().Trim();
                Solution obj = new Solution();
                int res = obj.lcs(N, M, s1, s2);
                Console.Write(res+"\n");
          }

        }
    }
}
// } Driver Code Ends


//User function Template for C#

class Solution
    {
        int[,] dp;
        int LCSLength = int.MinValue;
        
        public int LCS(int i, int j, string A, string B){
            if(i < 0 || j< 0){
                return 0;
            }
            if(dp[i, j] != -1){
                return dp[i,j];
            }
            int ans = 0;
            if(A[i] == B[j]){
                ans = 1 + LCS(i-1, j-1, A, B);
            }else{
                ans = Math.Max(LCS(i-1, j, A, B), LCS(i, j-1, A, B));
            }
            dp[i,j] = ans;
            LCSLength = Math.Max(LCSLength, ans);
            return ans;
            
        }
        public int lcs(int x, int y,string s1, string s2)
        {
            dp = new int[x, y];
            for(int i = 0; i<x; i++){
                for(int j = 0; j<y; j++){
                    dp[i,j] = -1;
                }
            }
            LCS(x-1, y-1, s1, s2);
            return LCSLength;
        }

    }