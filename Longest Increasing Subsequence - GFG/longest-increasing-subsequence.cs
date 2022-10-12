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
                int N = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[N];

                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                arr = Array.ConvertAll(elements.Split(), int.Parse);

                Solution obj = new Solution();
                int res = obj.longestSubsequence(N, arr);
                Console.Write(res+"\n");
          }

        }
    }
}

// } Driver Code Ends


//User function Template for C#

class Solution
    {
        int[] dp;
        int LIS = int.MinValue;
        
        public int lis(int[] arr, int i){
            if(dp[i] != 0){
                return dp[i];
            }
            int ans = 1;
            for(int j = 0; j<i; j++){
                if(arr[j] < arr[i]){
                    ans = Math.Max(ans, 1+lis(arr, j));
                }
            }
            dp[i] = ans;
            LIS = Math.Max(LIS, ans);
            return ans;
        }
        public int longestSubsequence(int n, int[] arr)
        {
            dp = new int[n];
            for(int i = 0; i<n; i++){
                lis(arr, i);
            }
            return LIS;
        }

    }
