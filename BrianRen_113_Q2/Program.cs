int weightTotal, n;
List<int> w = new(), v = new();


Console.Write("輸入物品的總數量：");
n = int.Parse(Console.ReadLine());
Console.Write("輸入背包的最大承載量（10的倍數）：");
weightTotal = int.Parse(Console.ReadLine());
Console.WriteLine("輸入各物品的重量與價值：");
for(int i = 1; i <= n; i++)
{
    Console.Write($"物品{i} - 重量：");
    w.Add(int.Parse(Console.ReadLine()));
    Console.Write($"物品{i} - 價值：");
    v.Add(int.Parse(Console.ReadLine()));
}
