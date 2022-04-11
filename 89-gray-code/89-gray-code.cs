public class Solution {
    
    public void reverse(IList<int> p){
        int start = 0;
        int end = p.Count-1;
        while(start < end){
            int temp = p[start];
            p[start] = p[end];
            p[end] = temp;
            start++;
            end--;
        }
    }
    public IList<int> GrayCode(int n) {
        IList<int> result = new List<int>();
        
        if(n == 1){
            result.Add(0);
            result.Add(1);
            return result;
        }
        
        IList<int> p = GrayCode(n-1);
        foreach(int num in p){
            result.Add(num);
        }
        reverse(p);
        foreach(int num in p){
            result.Add((1<<(n-1)) + num);
        }
        
        return result;
    }
}