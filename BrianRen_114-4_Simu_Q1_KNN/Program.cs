// See https://aka.ms/new-console-template for more information
/*
7 2
[[1, 1], [2, 2], [3, 3], [8, 8], [9, 9], [10, 10], [11, 11]]
[0, 0, 0, 1, 1, 1, 1]
[[1, 2], [9, 8], [6, 6]]
 */

var raw = Console.ReadLine().Split().Select(int.Parse).ToList();
var n = raw[0];
var m = raw[1];
raw = Console.ReadLine().Replace("[", "").Replace("]", "").Replace(",", "").Split().Select(int.Parse).ToList();
var data = new List<List<int>>();
for (var i = 0; i < raw.Count / m; i++)
{
    data.Add(new List<int>());
    for (var j = 0; j < m; j++) data[i].Add(raw[i * m + j]);
}

raw = Console.ReadLine().Replace("[", "").Replace("]", "").Replace(",", "").Split().Select(int.Parse).ToList();
var labels = raw;
raw = Console.ReadLine().Replace("[", "").Replace("]", "").Replace(",", "").Split().Select(int.Parse).ToList();
var td = new List<List<int>>();
for (var i = 0; i < raw.Count / m; i++)
{
    td.Add(new List<int>());
    for (var j = 0; j < m; j++) td[i].Add(raw[i * m + j]);
}

var dists = td.Select(a =>
    data.Select((b, i) => (Tag: labels[i], Value: Dist(a, b)))
        .OrderBy(x => x.Value)
        .Take(3)
        .GroupBy(x => x.Tag)
        .Select(x=>x.ToList())
        .OrderByDescending(x => x.Count())
        .ThenBy(x=>x.Min(y=>y.Value))
        // .ToList())
        .First().First().Tag)
    .ToList();

Console.WriteLine($"[{string.Join(", ", dists)}]");
// Console.WriteLine(string.Join("\n", dists.Select(x=>string.Join(", ",x.Select(y=>string.Join(" ", y))))));
double Dist(List<int> a, List<int> b)
{
    double sum = 0;
    for (var i = 0; i < a.Count; i++) sum += Math.Pow(a[i] - b[i], 2);

    return Math.Sqrt(sum);
}