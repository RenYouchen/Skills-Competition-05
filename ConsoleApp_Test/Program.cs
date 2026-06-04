List<int> nList = new List<int>([1,2]);

Console.WriteLine(string.Join(" ",nList.Select(x => x += 1).ToList()));

int a, b;
(a, b) = nList switch { var x => (x[0], x[1]) };
string s="123456";
var test = s.OrderByDescending(x => x);
Console.WriteLine($"a:{a} b:{b}");
Console.WriteLine(string.Join(' ', test));
Console.WriteLine($"{123.4567:P}");