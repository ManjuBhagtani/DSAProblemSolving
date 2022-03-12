public class Solution {
    public string DefangIPaddr(string address) {
        StringBuilder sb = new StringBuilder("");
        int n = address.Length;
        for(int i=0; i<n; i++){
            if(address[i] != '.'){
                sb.Append(address[i]);
            }else{
                sb.Append("[.]");
            }
        }
        return sb.ToString();
    }
}