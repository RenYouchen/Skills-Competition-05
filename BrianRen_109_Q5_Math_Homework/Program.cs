using System.Data;
while (true)
{
    Console.WriteLine("請輸入運算式：（輸入@結束）");
    string raw = Console.ReadLine();
    if(raw=="@") break;
    int temp = 0;
    List<string> calc = new List<string>();
    foreach (var c in raw)
    {
        if (char.IsDigit(c))
        {
            temp = (10 * temp + int.Parse($"{c}")) % 10000;
        }
        else
        {
            calc.Add(temp.ToString());
            calc.Add($"{c}");
            temp = 0;
        }
    }
    calc.Add(temp.ToString());
    Console.WriteLine("妳輸入的數學運算式為:");
    Console.WriteLine($"運算結果 = {Convert.ToInt32(new DataTable().Compute(string.Join("", calc), null)) % 10000}");
}