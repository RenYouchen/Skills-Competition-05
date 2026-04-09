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

