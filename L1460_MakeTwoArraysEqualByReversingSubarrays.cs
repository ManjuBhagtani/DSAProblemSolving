/*

You are given two integer arrays of equal length target and arr. In one step, you can select any non-empty sub-array of arr and reverse it. You are allowed to make any number of steps.

Return true if you can make arr equal to target or false otherwise.

Example 1:

Input: target = [1,2,3,4], arr = [2,4,1,3]
Output: true
Explanation: You can follow the next steps to convert arr to target:
1- Reverse sub-array [2,4,1], arr becomes [1,4,2,3]
2- Reverse sub-array [4,2], arr becomes [1,2,4,3]
3- Reverse sub-array [4,3], arr becomes [1,2,3,4]
There are multiple ways to convert arr to target, this is not the only way to do so.


Example 2:

Input: target = [7], arr = [7]
Output: true
Explanation: arr is equal to target without any reverses.


Example 3:

Input: target = [3,7,9], arr = [3,7,11]
Output: false
Explanation: arr does not have value 9 and it can never be converted to target.
 

Constraints:

target.length == arr.length
1 <= target.length <= 1000
1 <= target[i] <= 1000
1 <= arr[i] <= 1000

*/

public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        //Dump everthing in target array to a dictionary. key = element, value = frequency
        for(int i = 0; i<target.Length; i++){
            if(map.ContainsKey(target[i])){
                map[target[i]]++;
            }else{
                map.Add(target[i], 1);
            }
        }
        
        //check if dictionary contains all elements in arr
        foreach(int element in arr){
            if(map.ContainsKey(element)){
                map[element]--;
            }else{
                return false; //dictionary doesn't contain an elemnt from arr.
            }
            if(map[element] == 0){
                map.Remove(element);
            }
        }
        
        //After processing both arrays, if map is empty, that means arr & target had same elements.
        if(map.Count == 0){ 
            return true;
        }
        return false;
    }
}

/*
	TC = O(N)
	SC = O(N)
*/