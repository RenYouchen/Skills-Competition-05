// See https://aka.ms/new-console-template for more information

var raw = Console.ReadLine();
var group = raw.GroupBy(x=>x).ToList();
string result = "";

foreach (var g in group)
{
    result += $"{g.Key}{g.Count()}";
}
Console.WriteLine(raw.Length > result.Length ? result : raw);
Console.ReadKey();