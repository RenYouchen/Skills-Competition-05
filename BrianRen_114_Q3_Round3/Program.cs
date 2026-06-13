var n = int.Parse(Console.ReadLine());
List<List<int>> g = Enumerable.Repeat(0, n+1).Select(_=> new List<int>()).ToList();
for (int i = 0; i < n - 1; i++)
{
    var a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
    g[a[0]].Add(a[1]);
    g[a[1]].Add(a[0]);
}
List<bool> v = Enumerable.Repeat(false, n+1).ToList();

(int, int) dfs(int currentNode, int depth)
{
    v[currentNode] = true;
    int farestNode = currentNode;
    int maxDepth = depth;

    foreach (var n in g[currentNode])
    {
        if (!v[n])
        {
            var rt = dfs(n, depth + 1);
            if (rt.Item2 > maxDepth)
            {
                (farestNode, maxDepth) = rt;
            }
        }
    }

    return (farestNode, maxDepth);
}

var x = dfs(1,0);
for (int i = 0; i < v.Count; i++) v[i] = false;
Console.WriteLine(dfs(x.Item1,0).Item2);
