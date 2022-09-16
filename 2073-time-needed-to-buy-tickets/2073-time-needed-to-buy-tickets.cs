class Person{
    public int id;
    public int tickets;
    
    public Person(int ID, int t){
        id = ID;
        tickets = t;
    }
}
public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        Queue<Person> q = new Queue<Person>();
        
        int n = tickets.Length;
        
        for(int i = 0; i<n; i++){
            q.Enqueue(new Person(i, tickets[i]));
        }
        
        int seconds = 0;
        
        while(true){
            Person front = q.Dequeue();
            
            front.tickets--;
            seconds++;
            if(front.tickets != 0){
                q.Enqueue(front);
            }
            if(front.id == k && front.tickets == 0){
                break;
            }
            
        }
        
        return seconds;
    }
}
