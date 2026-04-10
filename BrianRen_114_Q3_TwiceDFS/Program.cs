//測資
//8
//7 4
//7 5
//7 6
//8 7
//6 3
//4 1
//4 2
// 

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

//Debug info
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

//用兩次的DFS找出樹的直徑
//先隨意取一個點 找出最長的一條路徑 該點為Z
//再在Z點上做DFS，找出另一條最長路徑 此為樹的直徑
//ref:https://oi-wiki.org/graph/tree-diameter/、https://oi-wiki.org/graph/dfs/#__tabbed_1_1
(int, int) dfs(int v)
{
    List<bool> visited = Enumerable.Repeat(false, N+1).ToList();
    (int, int) z = (-1, -1);
    List<int> dict = Enumerable.Repeat(0, N + 1).ToList();
    Stack<int> stack = new Stack<int>();

    stack.Push(v);

    while (stack.Count != 0)
    {
        int x = stack.Pop();
        visited[x] = true;
        foreach (var i in graph[x])
        {
            if(visited[i]) continue;
            dict[i] = dict[x] + 1;
            z.Item1 = i;
            z.Item2 = dict[i];
            stack.Push(i);
        }
    }
    // Console.WriteLine(z);
    return z;
}

Console.WriteLine("====================");
Console.WriteLine($"輸出：最遠血緣關係距離為{dfs(dfs(1).Item1).Item2}");
// List<int> path = Enumerable.Repeat(0, N+1).ToList();
//
// for (int i = 1; i <= N; i++)
// {
//     for (int j = 0; j < graph[i].Count; j++)
//     {
//         path[graph[i][j]] += 1;
//     }
// }
//
//
// Queue<int> queue = new Queue<int>();
//
// for (int i = 1; i < path.Count; i++)
// {
//     if (path[i] == 0)
//     {
//         queue.Enqueue(i);
//     }
// }
//
// List<int> topo = new List<int>();
// for (int i = 1; i <= N; i++)
// {
//     if (queue.Count == 0) break; //是迴圈 沒有沒被連向的點
//     int vNow = queue.Dequeue();
//     path[vNow] = -1;
//     topo.Add(vNow);
//     Console.Write($"{vNow} -> ");
//     
//     foreach (var j in graph[vNow])
//     {
//         path[j] -= 1;
//         if (path[j] == 0) queue.Enqueue(j);
//     }
// }
//
// List<int> dist = Enumerable.Repeat(-1, N+1).ToList();
// dist[1] = 0;
//
// foreach (var i in topo)
// {
//     if (dist[i] == -1)
//     {
//         foreach (var j in graph[i])
//         {
//             if (dist[j] < dist[i]+1)
//             {
//                 dist[j] = dist[i] + 1;
//             }
//         } 
//     }
// }
//
// foreach (var i in dist)
// {
//     Console.Write($"{i} ");
// }