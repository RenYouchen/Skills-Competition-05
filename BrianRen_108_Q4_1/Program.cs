int n = int.Parse(Console.ReadLine());
while (n-- > 0)
{
    int V, E;
    V = int.Parse(Console.ReadLine());
    E = int.Parse(Console.ReadLine());
    var g = Enumerable.Range(0, V).Select(_=>new List<int>()).ToList();
    for (int i = 0; i < E; i++)
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        g[input[0]].Add(input[1]);
    }

    Console.WriteLine(bfs(g, 0));
}

bool bfs(List<List<int>> g, int s)
{
    int n = g.Count;
    List<int> vcolor = Enumerable.Repeat(0, n).ToList();
    Queue<int> todo = new Queue<int>();
    todo.Enqueue(s);
    vcolor[s] = 1;
    while (todo.Count!=0)
    {
        int v = todo.Dequeue();
        foreach (var i in g[v])
        {
            if (vcolor[i] == 0)
            {
                vcolor[i] = -vcolor[v];
                todo.Enqueue(i);
            }
            else if (vcolor[i] == vcolor[v])
            {
                return false;
            }
        }
    }

    return true;
}

/*
2
4
4
0 1
1 2
2 3
3 0
5
10
0 1
0 2
0 3
0 4
1 2
1 3
1 4
2 3
2 4
3 4
 */