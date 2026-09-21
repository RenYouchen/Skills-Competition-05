// See https://aka.ms/new-console-template for more information
// Input ==> 123,456,789,123,456,789*80000
// Output ==> 9,876,543,129,876,543,120,000

using System.Numerics;
using System.Text.RegularExpressions;

string input;
// string input = "123,456,789,123,456,789*80000";
// BigInteger inputInt = BigInteger.Parse(string.Join("",input.Split(',')));
// BigInteger inputInt = BigInteger.Parse(input.Replace(",", "")); //更好的做法

while ((input = Console.ReadLine()) != null)
{
    input = input.Replace(",", "");
    List<string> calc = Regex.Matches(input, @"\d+|[+\-*/]").Select(m=>m.Value).ToList();
    Console.WriteLine(string.Join(" ", calc));

    
    for (int i = 0; i < calc.Count; i++)
    {
        // if(calc.Count == 1) break;
        if (calc[i] == "*" || calc[i] == "/")
        {
            BigInteger a = BigInteger.Parse(calc[i - 1]);
            BigInteger b = BigInteger.Parse(calc[i + 1]);
            BigInteger result = calc[i] == "*" ? a * b : a / b;
            calc.RemoveRange(i - 1,3);
            calc.Insert(i-1,result.ToString());
            i--;
        } 
    }

    for (int i = 0; i < calc.Count; i++)
    {
        if (calc[i] == "+" || calc[i] == "-")
        {
            BigInteger a = BigInteger.Parse(calc[i - 1]);
            BigInteger b = BigInteger.Parse(calc[i + 1]);
            BigInteger result = calc[i] == "+" ? a + b : a - b;
            calc.RemoveRange(i - 1,3);
            calc.Insert(i-1,result.ToString());
            i--;
        }
    }
    Console.WriteLine(BigInteger.Parse(calc.First()).ToString("N0"));
}
