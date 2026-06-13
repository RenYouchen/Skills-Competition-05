var n = int.Parse(Console.ReadLine());
List<List<int>> graph = Enumerable.Repeat(0, n+1).Select(_=>new List<int>()).ToList();

for (int i = 0; i < n - 1; i++)
{
    var a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
    graph[a[0]].Add(a[1]);
    graph[a[1]].Add(a[0]);
}

List<bool> visited = Enumerable.Repeat(false, n + 1).ToList();

(int, int) dfs(int currentNode, int depth)
{
    visited[currentNode] = true;
    int farestNode = currentNode;
    int maxDepth = depth;
    
    foreach (var n in graph[currentNode])
    {
        if (!visited[n])
        {
            var a = dfs(n, depth + 1);
            if (a.Item2 > maxDepth)
            {
                farestNode = a.Item1;
                maxDepth = a.Item2;
            }
        }
    } 
    return (farestNode, maxDepth);
}

var x = dfs(1,0);
for (int i = 0; i < visited.Count; i++)
{
    visited[i] = false;
}

var y = dfs(x.Item1, 0);
Console.WriteLine(y.Item2);