int N;

Console.WriteLine("請輸入節點數 N:");

N = Int32.Parse(Console.ReadLine());

Console.WriteLine("請輸入N-1行血緣關係（每行兩個整數，以空格分隔）：");

List<List<int>> graph = [];

for (int i = 0; i <= N; i++)
{
    graph.Add([]);
}

for (int i = 0; i < N-1; i++)
{
    int a, b;
    List<string> s = Console.ReadLine().Split(" ").ToList();
    a = Int32.Parse(s[0]);
    b = Int32.Parse(s[1]);
    graph[a].Add(b);
    graph[b].Add(a);
}

// foreach (var i in graph)
// {
//     Console.Write(graph.IndexOf(i) + " ");
//     foreach (var j in i)
//     {
//         Console.Write(j);
//         Console.Write(" ");
//     }
//     Console.WriteLine();
// }

var max = -1;

for (int i = 1; i <= N; i++)
{
    List<int> dict = Enumerable.Repeat(-1, N+1).ToList();
    Queue<int> queue = new Queue<int>();
    dict[i] = 0;
    queue.Enqueue(i);
    while (queue.Count != 0)
    {
        int v = queue.Dequeue();
        foreach (var j in graph[v])
        {
            if(dict[j] != -1) continue;
            dict[j] = dict[v] + 1;
            if (max < dict[j])
            {
                max = dict[j];
            }
            queue.Enqueue(j);
        }
    }
}

Console.WriteLine("====================");
Console.WriteLine($"輸出：最遠血緣關係距離為{max}");
