/*
6 2
2 50
4 60
5 68
7 72
8 85
10 90
6
9 
 */

var NQ = Console.ReadLine().Split().Select(decimal.Parse).ToList();
decimal N = NQ[0]; decimal Q = NQ[1];
List<(decimal, decimal)> hs = new List<(decimal, decimal)> ();
List<decimal> p = new List<decimal> ();

for(int i = 0; i < N; i++)
{
    var data = Console.ReadLine().Split().Select(decimal.Parse).ToList();
    hs.Add((data[0], data[1]));
}
for(int i = 0; i < Q; i++)
{
    p.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine($"COUNT {hs.Count()}");
Console.WriteLine($"AVERAGE {(float)hs.Select(x=>x.Item2).Average():F2}");
hs.Sort((a,b)=> a.Item1.CompareTo(b.Item2));

Console.WriteLine($"MEDIAN {hs[hs.Count/2]}");
Console.WriteLine($"STDDEV {hs.Count()}");
Console.WriteLine($"PASS_RATE {hs.Count()}");
Console.WriteLine($"MAX {hs.Count()}");
Console.WriteLine($"MIN {hs.Count()}");
Console.WriteLine($"CORRELATION {hs.Count()}");
Console.WriteLine($"SLOPE {hs.Count()}");
Console.WriteLine($"INTERCEPT {hs.Count()}");


Console.WriteLine($"PREDICT {hs.Count()}");
