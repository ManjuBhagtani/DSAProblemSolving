public class Solution {
    public bool SquareIsWhite(string coordinates) {
        if(coordinates[0]%2 != 0){ //a, c, e, g
            if(coordinates[1]%2 != 0){
                return false;
            }
            return true;
        }else{ //b, d, f, h
            if(coordinates[1]%2 != 0){
                return true;
            }
            return false;
        }
        
        /*
            TC = O(1)
            SC = O(1)
        */
    }
}