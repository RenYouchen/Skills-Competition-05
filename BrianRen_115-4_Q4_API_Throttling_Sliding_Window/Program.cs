// See https://aka.ms/new-console-template for more information
/*
3 1
9
0 A
1 A
2 A
2 B
3 A
3 A
4 A
4 B
5 B
*/


var WL = Console.ReadLine().Split().Select(int.Parse).ToList();
int W = WL[0], L = WL[1];
int Q = int.Parse(Console.ReadLine());

var allowed = new Dictionary<string, Queue<int>>();
var result = new List<string>();

for(int i = 0; i< Q; i++)
{
    var tmp = Console.ReadLine().Split();
    int t = int.Parse(tmp[0]);
    string u = tmp[1];

    if (!allowed.TryGetValue(u, out var q))
    {
        allowed[u] = q = new Queue<int>();
    }

    while (q.Count > 0 && q.Peek() <= t - W)
    {
        q.Dequeue();
    }

    if (q.Count < L)
    {
        result.Add("ALLOW");
        q.Enqueue(t);
    }
    else
    {
        result.Add("REJECT");
    }
}
Console.WriteLine(string.Join("\n", result));
