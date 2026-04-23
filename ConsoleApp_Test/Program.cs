List<int> nList = new List<int>([1,2]);

Console.WriteLine(string.Join(" ",nList.Select(x => x += 1).ToList()));