// See https://aka.ms/new-console-template for more information
/*
1 2 35
2 3 45
2 4 30
3 5 45
3 6 20
4 5 45
4 7 130
5 7 70
6 7 100
 */

string s;
var map = new Dictionary<int, List<(int,int)>>();
while ((s = Console.ReadLine()) != null && s.Trim() != "")
{
    var ss = s.Split().Select(int.Parse).ToList();
    if (!map.ContainsKey(ss[0])) map[ss[0]] = new List<(int, int)>();
    map[ss[0]].Add((ss[1], ss[2]));
}

var maxNode = map.Keys.Concat(map.Values.SelectMany(list => list.Select(x=>x.Item1))).Max();
var dist = Enumerable.Repeat(int.MaxValue, maxNode+1).ToArray();
var prev = Enumerable.Repeat((-1,-1), maxNode+1).ToArray();
var pq = new PriorityQueue<int,int>(); //Node, Dist

dist[1] = 0;
pq.Enqueue(1, 0);

while (pq.TryDequeue(out var u, out var d))
{
    if(d > dist[u]) continue;
    if(!map.TryGetValue(u, out var edge)) continue; 
    foreach (var (v, w) in edge)
    {
        if (dist[u] + w < dist[v])
        {
            dist[v] = dist[u] + w;
            prev[v] = (u, w);
            pq.Enqueue(v, dist[v]);
        } 
    }
}

List<(int, int)> path = new List<(int, int)>();


var cur = maxNode;
while (cur != -1)
{
    path.Add((cur, prev[cur].Item2));
    cur = prev[cur].Item1;
}
path.Reverse();

path[0] = (path[0].Item1, 0);
Console.WriteLine($"最低成本值總和:{dist[maxNode]}");
Console.WriteLine($"路徑次序:{string.Join("\t", path.Select(x=>x.Item1))}");
Console.WriteLine($"連線數值:{string.Join("\t", path.Select(x=>x.Item2))}");
