Console.WriteLine("請輸入節點數N：");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("請輸入N-1行血緣關係(每行兩個整數，以空格分割)");
List<List<int>> graph = Enumerable.Repeat(0, N+1).Select(_=>new List<int>()).ToList();

for (int i = 0; i < N - 1; i++)
{
    var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
    graph[input[0]].Add(input[1]);
    graph[input[1]].Add(input[0]);
}

List<bool> visited = Enumerable.Repeat(false, N+1).ToList();

(int, int) DFS(int currentNode, int depth)
{
    visited[currentNode] = true;
    var farestNode = currentNode;
    int maxDepth = depth;
    foreach (var node in graph[currentNode]) 
    {
        if (!visited[node])
        {
            var (x, y) = DFS(node, depth + 1);
            if (y > maxDepth)
            {
                (farestNode, maxDepth) = (x, y);
            }
        }
    }
    return (farestNode, maxDepth);
}

var (x,y) = DFS(1,0);
for (int i = 0; i < visited.Count; i++)
{
    visited[i] = false;
}
var a = DFS(x, 0);
Console.WriteLine(a.Item2);