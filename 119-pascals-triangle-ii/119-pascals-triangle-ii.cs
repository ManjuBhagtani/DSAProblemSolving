public class Solution {
    public IList<int> GetRow(int rowIndex) {
        if(rowIndex == 0){
            return new List<int>{1};
        }
        if(rowIndex == 1){
            return new List<int>{1,1};
        }
        IList<int> prevRow = GetRow(rowIndex-1);
        List<int> currentRow = new List<int>(rowIndex+1);
        currentRow.Add(1);
        for(int i = 1; i<rowIndex; i++){
            currentRow.Add(prevRow[i]+prevRow[i-1]);
        }
        currentRow.Add(1);
        
        return currentRow;
    }
}