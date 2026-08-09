var input = File.ReadLines("base_convert_tests.txt");
foreach (var lines in input)
{
    var data = lines.Split(' ').Select(int.Parse).ToList();
    int n = data[0];
    int b = data[1];
    int x = n;
    string result = "";
    while (x != 0)
    {
        int r = x % b;
        x /= b;
        if (r < 0)
        {
            r += Math.Abs(b);
            x+=1;
        }
        result = result.Insert(0, $"{"0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"[r]}");
    }
    Console.WriteLine($"{$"n={n}, base={b}",-20} -> {result}");
}

