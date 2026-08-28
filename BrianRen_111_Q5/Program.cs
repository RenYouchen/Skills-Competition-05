Console.Write("Enter file name:");
string[] input = File.ReadAllLines($"../../../{Console.ReadLine()}");
Console.WriteLine("所輸入的對稱矩陣：");
Console.WriteLine($"{string.Join('\n', input)}");
var inputDouble = input.Select(x => x.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList()).ToList();

while (true)
{
    List<List<double>> result = inputDouble.Select(x=>x.ToList()).ToList();
    bool isChanged = false;
    for (int i = 0; i < inputDouble.Count; i++)
    {
        for (int j = 0; j < inputDouble[i].Count; j++)
        {
            double max = double.MinValue;
            for (int k = 0; k < inputDouble[i].Count; k++)
            {
                max = Math.Max(max, Math.Min(inputDouble[i][k], inputDouble[k][j]));
            }

            if (Math.Round(max,4) != Math.Round(inputDouble[i][j],4))
            {
                result[i][j] = max;
                isChanged = true;
            }
        }
    }
    if(isChanged == false) break;
    inputDouble = result;
}

//Output
Console.WriteLine("經過幾次遞移律(Transitive Closure)運算後的對稱矩陣");
Console.WriteLine($"{string.Join('\n', inputDouble.Select(x=>$"{string.Join("  ", x.Select(v=>$"{v:F2}"))}"))}");
List<double> res = new List<double>();
Console.WriteLine("對稱矩陣的右上半每列最大值：");
for (int i = 0; i < inputDouble.Count-1; i++)
{
    double max = double.MinValue;
    for (int k = i+1; k < inputDouble.Count; k++)
    {
        int a = k + 1;
        max = Math.Max(max, inputDouble[i][k]);
    }
    res.Add(max);
}
Console.WriteLine(string.Join("  ", res.Select(x=>$"{x:F2}")));

Console.WriteLine("對稱矩陣的右上半每列最大值的排序(各值只出現一次)：");
res.Sort();
res = res.Distinct().ToList();
Console.WriteLine(string.Join("  ", res.Select(x=>$"{x:F2}")));

