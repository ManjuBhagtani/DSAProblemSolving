public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        //find Nearest Greater Element on right for every element in nums2
        //foreach element in nums1, find its position in nums 2. resture ans for that position
        
        Stack<int> stack = new Stack<int>();
        
        int n2 = nums2.Length;
        int[] NSR = new int[n2];
        
        Dictionary<int, int> nums2PosMap = new Dictionary<int, int>();
        
        for(int i = n2-1; i>=0; i--){
            nums2PosMap.Add(nums2[i], i);
            
            while(stack.Count > 0 && stack.Peek() <= nums2[i]){
                stack.Pop();
            }
            if(stack.Count > 0 ){
                NSR[i] = stack.Peek();
            }else{
                NSR[i] = -1;
            }
            stack.Push(nums2[i]);
        }
        
        int n1 = nums1.Length;
        int[] ans = new int[n1];
        
        for(int i = 0; i<n1; i++){
            int posInNums2 = nums2PosMap[nums1[i]];
            ans[i] = NSR[posInNums2];
        }
        
        return ans;
    }
}

/*
    TC = O(nums1.length + nums2.length)
    SC = O(nums1.length + nums2.length)
*/