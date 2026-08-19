//12345678901234567890
//98765432109876543210

string inA = "2222222222222222222222222";
string inB = "1111111111111111111111111";

if (inA.Length < inB.Length) inA = inA.PadLeft(inB.Length, '0');
else if (inB.Length < inA.Length) inB = inB.PadLeft(inA.Length, '0');

var charA = inA.ToCharArray().Reverse().ToList();
var charB = inB.ToCharArray().Reverse().ToList();

List<string> result = new List<string>();
int c = 0;
for (int i = 0; i < charB.Count; i++)
{
    result.Add("");
    for (int j = 0; j < charA.Count; j++)
    {
        int multiply = int.Parse(charA[j].ToString()) * int.Parse(charB[i].ToString()) + c;
        c = 0;
        if (multiply >= 10)
        {
            c = multiply / 10;
        }

        result[^1] = result.Last().Insert(0, $"{multiply % 10}");
    }

    result[^1] = result[^1].PadRight(result[^1].Length-1 + result.Count, '0');
    
}

string output = result[0];
for (int i = 0; i < result.Count-1; i++)
{
    
    output = sum(output, result[i + 1]);
}

output = output.TrimStart('0');
Console.WriteLine(output);

string sum(string inA, string inB)
{
    if (inA.Length < inB.Length) inA = inA.PadLeft(inB.Length, '0');
    else if (inB.Length < inA.Length) inB = inB.PadLeft(inA.Length, '0');

    var charA = inA.ToCharArray().Reverse().ToList();
    var charB = inB.ToCharArray().Reverse().ToList();

    string result = "";
    int c = 0;
    for (int i = 0; i < charA.Count; i++)
    {
        int sum = int.Parse(charA[i].ToString()) + int.Parse(charB[i].ToString()) + c;
        c = 0;
        if (sum >= 10)
        {
            c = sum / 10;
        }

        result = result.Insert(0, $"{sum % 10}");
    }

    if (c != 0)
    {
        result = result.Insert(0, $"{c}");
    }

    return result;
}

// if (c != 0)
// {
//     result = result.Insert(0, $"{c}");
// }
Console.WriteLine(result);