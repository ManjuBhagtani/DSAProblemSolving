public class Solution {
    public int[] SumEvenAfterQueries(int[] nums, int[][] queries) {
        int n = nums.Length;
        int q = queries.Length;
        
        int[] ans = new int[q];
        
        int evenSum = 0;
        HashSet<int> indexesWithEvenValues = new HashSet<int>();
        
        for(int i = 0; i < n; i++){             //O(n)
            if((nums[i]&1) == 0){ //even
                evenSum += nums[i];
                indexesWithEvenValues.Add(i);
            }
        }
        
        for(int i = 0; i<q; i++){               //O(q)
            int valueToAdd = queries[i][0];
            int indexToAddTo = queries[i][1];
            
            int prevValue = nums[indexToAddTo];
            
            if(indexesWithEvenValues.Contains(indexToAddTo)){ //it was already even previously as well
                evenSum -= prevValue;
                indexesWithEvenValues.Remove(indexToAddTo);
            }
            
            nums[indexToAddTo] += valueToAdd;
            
            if((nums[indexToAddTo]&1) == 0){ //new value is even
                evenSum += nums[indexToAddTo];
                indexesWithEvenValues.Add(indexToAddTo);
            }
            
            ans[i] = evenSum;
        }
        
        return ans;
    }
}

/*
    TC = O(n+q)
    SC = O(n) for HashSet
*/