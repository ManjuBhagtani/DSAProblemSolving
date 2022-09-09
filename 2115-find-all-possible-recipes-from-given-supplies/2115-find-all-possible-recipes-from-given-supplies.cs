public class Solution {
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies) {
        int n = recipes.Length;
        
        Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();
        //Key = ingredient, Value = list of recipes that need this ingredient
        
        Dictionary<string, int> indegree = new Dictionary<string, int>();
        //Key = ingredient, value = no. of ingredients needed to make that ingredient
        
        for(int i = 0; i<n; i++){ //ith recipe
            foreach(string ingredient in ingredients[i]){
                if(!graph.ContainsKey(ingredient)){
                    graph.Add(ingredient, new List<string>());
                }
                graph[ingredient].Add(recipes[i]);
                if(!indegree.ContainsKey(ingredient)){
                    indegree.Add(ingredient, 0);
                }
            }
            if(!graph.ContainsKey(recipes[i])){
                graph.Add(recipes[i], new List<string>());
            }
            if(!indegree.ContainsKey(recipes[i])){
                indegree.Add(recipes[i], ingredients[i].Count);
            }else{
                indegree[recipes[i]] = ingredients[i].Count;
            }
        }
        
        HashSet<string> suppliesSet = new HashSet<string>();
        foreach(string supply in supplies){
            suppliesSet.Add(supply);
        }
        
        Queue<string> q = new Queue<string>();
        foreach(KeyValuePair<string, int> ingredientIndegree in indegree){
            string ingredient = ingredientIndegree.Key;
            int indeg = ingredientIndegree.Value;
            
            if(suppliesSet.Contains(ingredient) && indeg == 0){
                q.Enqueue(ingredient);
            }
        }
        
        IList<string> ans = new List<string>();
        
        while(q.Count > 0){
            string front = q.Dequeue();
            foreach(string recipe in graph[front]){
                indegree[recipe]--;
                if(indegree[recipe] == 0){
                    ans.Add(recipe);
                    q.Enqueue(recipe);
                }
            }
        }
        
        return ans;
    }
}

/*
    TC = O(V+E)
    SC = O(V+E)
*/