List<List<int>> box = Enumerable.Repeat(Enumerable.Repeat(0, 3).ToList(), 3).ToList();



foreach (var i in box)
{
    Console.WriteLine(string.Join(' ', i));
}