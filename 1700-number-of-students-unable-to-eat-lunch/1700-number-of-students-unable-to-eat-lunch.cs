public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int n = students.Length;
        
        Stack<int> stack = new Stack<int>(n);
        Queue<int> q = new Queue<int>(n);
        
        for(int i = n-1, j = 0; i>=0 && j<n; i--, j++){ //O(n)
            stack.Push(sandwiches[i]);
            q.Enqueue(students[i]);
        }
        
        while(n > 0){                       //O(n)
            if(q.Peek() == stack.Peek()){
                q.Dequeue();
                stack.Pop();
                n--;
            }else{
                int remainingStud = n;
                while(q.Peek() != stack.Peek() && remainingStud > 0){ //runs n times in total for all iterations of ourt loop
                    q.Enqueue(q.Dequeue());
                    remainingStud--;
                }
                if(remainingStud == 0){
                    return n;
                }
            }
        }
        return 0;
        
        /*
            TC = O(n)
            SC = O(n)
        */
    }
}
