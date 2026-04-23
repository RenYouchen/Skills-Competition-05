List<int> nList = new List<int>([1,2]);

Console.WriteLine(string.Join(" ",nList.Select(x => x += 1).ToList()));

int a, b;
(a, b) = nList switch { var x => (x[0], x[1]) };