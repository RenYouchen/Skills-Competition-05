// See https://aka.ms/new-console-template for more information

Console.Write("請輸入大地遊戲關卡文字檔檔名：");
string s = Console.ReadLine();
Console.WriteLine($"你輸入檔名為，'{s}'");
var raw = File.ReadAllLines($"../../../{s}");
Console.WriteLine("大地遊戲關卡文字檔內容為：");
Console.WriteLine(string.Join('\n', raw));

var n = int.Parse(raw[0]);
var startAndEnd = raw[n+1].Split().Select(int.Parse).ToList();
int start = startAndEnd.First() - 1;
int end = startAndEnd.Last() - 1;

List<List<(int, double)>> input = Enumerable.Range(0, n).Select(_ => new List<(int, double)>()).ToList();

for (int i = 1; i <= n; i++)
{
    var data = raw[i].Split().Select(double.Parse).ToList();
    for (int j = 0; j < n; j++)
    {
        if (data[j] != 0.0)
        {
            input[i-1].Add((j, data[j]));
        }
    }    
}

// var startAndEnd = raw[int.Parse(raw[0]) + 1].Split(' ').Select(int.Parse).ToList();
// List<List<(int, double)>> input = Enumerable.Range(0, int.Parse(raw[0])).Select(x=>new List<(int, double)>()).ToList();
// for(int i = 1; i <= int.Parse(raw[0]); i++)
// {
//     var data = raw[i].Split(' ').Select(double.Parse).ToList();
//     for (int j = 0; j < data.Count; j++)
//     {
//         if (data[j] != 0.0)
//         {
//             input[i-1].Add((j,data[j]));
//         }
//     }
// }
Console.WriteLine();

bool[] visited = new bool[n];
List<(double, int?)> dist = Enumerable.Repeat((double.PositiveInfinity, (int?)null), n).ToList();
dist[start] = (0, null);
for (int i = 0; i < n; i++)
{
    double minDist = double.PositiveInfinity;
    int minV = -1;
    for (int v = 0; v < n; v++)
    {
        if (!visited[v] && dist[v].Item1 < minDist)
        {
            minDist = dist[v].Item1;
            minV = v;
        }
    }
    
    if(minV == -1) break;
    visited[minV] = true;
    foreach (var node in input[minV])
    {
        double newDist = dist[minV].Item1 + node.Item2;
        if (newDist < dist[node.Item1].Item1)
        {
            dist[node.Item1] = (newDist, minV);
        }
    }
}

List<int?> path = new List<int?>();
int? currentNode = end;
while (currentNode != null)
{
    path.Add(currentNode+1);
    currentNode = dist[currentNode.Value].Item2;
} 
path.Reverse();
Console.Write($"最快的闖關路線[{start+1} -> {end + 1}] ");
Console.Write(string.Join("->", path));
Console.Write($" 路途險峻程度{dist[end].Item1}");
// bool[] used = Enumerable.Repeat(false, int.Parse(raw[0])).ToArray();
// double[] dist = Enumerable.Repeat(double.MaxValue, int.Parse(raw[0])).ToArray();
// dist[startAndEnd.First()-1] = 0;
// for (int i = 0; i < int.Parse(raw[0]); i++)
// {
//     double minDist = double.MaxValue;
//     int minV = -1;
//     for (int v = 0; v < int.Parse(raw[0]); v++)
//     {
//         if (!used[v] && dist[v] < minDist)
//         {
//             minDist = dist[v];
//             minV = v;
//         }
//     }
//     if(minV == -1) break;
//
//     used[minV] = true;
//     
//     foreach (var e in input[minV])
//     {
//         var a = dist[e.Item1];
//         var b = dist[minV] + e.Item2;
//         if (a > b)
//         {
//             dist[e.Item1] = b;
//         }
//     }
//
// }
// var result = dist.Select(d => d == double.MaxValue ? "-1" : d.ToString());
// Console.WriteLine(string.Join(' ', result));

 