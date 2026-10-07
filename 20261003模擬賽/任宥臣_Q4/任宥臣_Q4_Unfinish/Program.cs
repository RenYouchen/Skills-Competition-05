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
var avarage = (double)hs.Select(x => x.Item2).Average();
Console.WriteLine($"AVERAGE {avarage:F2}");
hs.Sort((a,b)=> a.Item2.CompareTo(b.Item2));
var mid = hs.Count % 2 == 1 ? hs[hs.Count / 2].Item2 : (hs[hs.Count / 2 - 1].Item2 + hs[hs.Count / 2].Item2) / 2;
Console.WriteLine($"MEDIAN {mid:F2}");
var stddev = Math.Sqrt(hs.Sum(x=>Math.Pow((double)x.Item2 - avarage, 2)) / (int)N);
Console.WriteLine($"STDDEV {stddev:F2}");
var passRate = (double)hs.Count(x => x.Item2 >= 60) / hs.Count * 100;
Console.WriteLine($"PASS_RATE {passRate:F2}%");
Console.WriteLine($"MAX {hs.Max(x=>x.Item2)}");
Console.WriteLine($"MIN {hs.Min(x=>x.Item2)}");
var xAverage = hs.Sum(x => x.Item1) / N;
var yAverage = hs.Sum(x => x.Item2) / N;
var Sxx = hs.Sum(x => Math.Pow((double)(x.Item1 - xAverage), 2));
var Syy = hs.Sum(x => Math.Pow((double)(x.Item2 - yAverage), 2));
var Sxy = (double)hs.Sum(x => (x.Item1 - xAverage) * (x.Item2 - yAverage));
var C = Sxy / Math.Sqrt(Sxx * Syy) ;
var S = (Sxx == 0?0:Sxy / Sxx);
var I = (double)yAverage - (S * (double)xAverage);
double Fix(double n) => Math.Abs(n) < 0.005 ? 0 : n;

Console.WriteLine($"CORRELATION {(double.IsNaN(C)? 0: Fix(C)):F2}");
Console.WriteLine($"SLOPE {(double.IsNaN(S)? 0: Fix(S)):F2}");
Console.WriteLine($"INTERCEPT {(double.IsNaN(I)? 0: Fix(I)):F2}");
foreach (var i in p)
{
    var Pi = (S * (double)i) + I;
    Console.WriteLine($"PREDICT {i} {(double.IsNaN(Pi)? 0: Fix(Pi)):F2}");
}

