// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.WriteLine("請輸入算式，例如1/2 + 5/8 + 6 - 2 + 1/3 / 5");

    var tokens = Console.ReadLine().Split().ToList();

    for (int i = 0; i < tokens.Count; i++)
    {
        var token = tokens[i];
        if (token == "*" || token == "/")
        {
            var lop = tokens[i - 1].Split('/').Select(int.Parse).ToList();
            var rop = tokens[i + 1].Split('/').Select(int.Parse).ToList();
            if (lop.Count == 1) lop.Add(1);
            if (rop.Count == 1) rop.Add(1);
            tokens.RemoveRange(i - 1, 3);
            i--;
            if (token == "/") rop.Reverse();
            tokens.Insert(i, $"{lop[0] * rop[0]}/{lop[1] * rop[1]}");
        }
    }

    for (int i = 0; i < tokens.Count; i++)
    {
        var token = tokens[i];
        if (token == "+" || token == "-")
        {
            var lop = tokens[i - 1].Split('/').Select(int.Parse).ToList();
            var rop = tokens[i + 1].Split('/').Select(int.Parse).ToList();
            if (lop.Count == 1) lop.Add(1);
            if (rop.Count == 1) rop.Add(1);
            tokens.RemoveRange(i - 1, 3);
            i--;
    
            if (token == "+")
            {
                tokens.Insert(i, $"{lop[0] * rop[1] + rop[0] * lop[1]}/{lop[1]*rop[1]}");
            }
            else if (token == "-")
            {
                tokens.Insert(i, $"{lop[0] * rop[1] - rop[0] * lop[1]}/{lop[1]*rop[1]}");
            }
        }
    }

    var tmp = tokens.First().Split('/').Select(int.Parse);
    var gcd = GCD(tmp.First(), tmp.Last());
    if(tmp.Last() / gcd != 1)
        Console.WriteLine($"{tmp.First()/gcd}/{tmp.Last()/gcd}");
    else 
        Console.WriteLine(tmp.First()/gcd);
} 

int GCD(int a, int b) => b==0? Math.Abs(a) : GCD(b, a % b);