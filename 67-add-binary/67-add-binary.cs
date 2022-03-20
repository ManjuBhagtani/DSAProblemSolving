public class Solution {
    
    public string reverse(StringBuilder sb){
        int end = sb.Length-1;
        int start = 0;
        while(start < end){
            char temp = sb[start];
            sb[start] = sb[end];
            sb[end] = temp;
            start++;
            end--;
        }
        return sb.ToString();
    }
    
    public string AddBinary(string a, string b) {
        int carry = 0;
        
        StringBuilder ans = new StringBuilder("");
        
        int i = a.Length-1;
        int j = b.Length-1;
        
        while(i>=0 || j>=0 || carry>0){
            int sum = carry;
            if(i >=0){
                sum += (a[i]-'0');
                i--;
            }
            if(j >= 0){
                sum += (b[j]-'0');
                j--;
            }
            ans.Append((char)(sum%2+'0'));
            carry = sum/2;
        }
                       
        return reverse(ans);
        
        /*
            TC = O(Max(a.Length, b.Length))
            SC = O(Max(a.Length, b.Length))
        */
    }
}
