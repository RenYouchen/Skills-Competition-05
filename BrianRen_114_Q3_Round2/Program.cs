Console.WriteLine("請輸入節點數N：");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("請輸入N-1行血緣關係(每行兩個整數，以空格分割)：");
List<List<int>> Graph = Enumerable.Repeat(0, N + 1).Select(_ => new List<int>()).ToList();

for (int i = 0; i < N-1; i++)
{
    var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
    Graph[input[0]].Add(input[1]);
    Graph[input[1]].Add(input[0]);
}

List<bool> Visited = Enumerable.Repeat(false, N + 1).ToList();

(int, int) DFS(int currentNode, int depth)
{
    Visited[currentNode] = true;
    int farestNode = currentNode;
    int maxDepth = depth;
    foreach (var v in Graph[currentNode])
    {
        if (!Visited[v]) {
            var (x,y) = DFS(v, depth + 1);
            if(y>maxDepth)
            {
                (farestNode, maxDepth) = (x, y);
            }
        };
    }

    return (farestNode, maxDepth);
}

int a = DFS(1, 0).Item1;
for (int i = 0; i < Visited.Count; i++)
{
    Visited[i] = false;
}
Console.WriteLine(DFS(a, 0));
