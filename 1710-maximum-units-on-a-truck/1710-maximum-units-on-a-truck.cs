class compare:IComparer<KeyValuePair<int, int>>{
    public int Compare(KeyValuePair<int, int> box1, KeyValuePair<int, int> box2){
        if(box1.Value > box2.Value){
            return -1;
        }else{
            if(box2.Value > box1.Value){
                return 1;
            }else{
                return 0;
            }
        }
    }
}
public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        int n = boxTypes.Length; //types of boxes
        List<KeyValuePair<int, int>> box = new List<KeyValuePair<int, int>>();
        
        for(int i = 0; i<n; i++){
            box.Add(new KeyValuePair<int, int>(boxTypes[i][0], boxTypes[i][1]));
        }
        
        compare cmp = new compare();
        box.Sort(cmp);
        
        int j = 0;
        
        int boxesChosen = 0;
        int units = 0;
        while(truckSize > 0 && j < n){
            boxesChosen = Math.Min(box[j].Key, truckSize);
            units += boxesChosen * box[j].Value;
            j++;
            truckSize -= boxesChosen;
        }
        
        return units;
    }
}