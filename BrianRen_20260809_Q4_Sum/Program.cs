//12345678901234567890
//98765432109876543210

string inA = "11111111111111111111111111111111";
string inB = "11111111111111111111111111111111";

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
Console.WriteLine(result);