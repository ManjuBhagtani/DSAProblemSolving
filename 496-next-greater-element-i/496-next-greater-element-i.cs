public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        //find Nearest Greater Element on right for every element in nums2
        //foreach element in nums1, find its position in nums 2. resture ans for that position
        
        Stack<int> stack = new Stack<int>();
        
        int n2 = nums2.Length;
        
        Dictionary<int, int> NSR = new Dictionary<int, int>(); //stores NSR for each element in nums2
        
        for(int i = 0; i<n2; i++){
            while(stack.Count > 0 && stack.Peek() < nums2[i]){
                NSR.Add(stack.Pop(), nums2[i]);
            }
            stack.Push(nums2[i]);
        }
        
        int n1 = nums1.Length;
        int[] ans = new int[n1];
        
        for(int i = 0; i<n1; i++){
            if(NSR.ContainsKey(nums1[i])){
                ans[i] = NSR[nums1[i]];
            }else{
                ans[i] = -1;
            }
        }
        
        return ans;
    }
}

/*
    TC = O(nums1.length + nums2.length)
    SC = O(nums1.length + nums2.length)
*/