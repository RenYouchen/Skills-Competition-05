int weightTotal, n;
List<int> w = new(), v = new();
List<List<int>> dp = new();

Console.Write("輸入物品的總數量：");
n = int.Parse(Console.ReadLine());
Console.Write("輸入背包的最大承載量（10的倍數）：");
weightTotal = int.Parse(Console.ReadLine());
Console.WriteLine("輸入各物品的重量與價值：");
w.Add(0); v.Add(0);
for(int i = 1; i <= n; i++)
{
    Console.Write($"物品{i} - 重量：");
    w.Add(int.Parse(Console.ReadLine())/10);
    Console.Write($"物品{i} - 價值：");
    v.Add(int.Parse(Console.ReadLine()));
}

for(int i = 0; i <= n; i++)
{
    dp.Add(Enumerable.Repeat(0, weightTotal / 10 + 1).ToList());
}

for(int i = 0; i < dp.Count; i++)
{
    for(int j = 0; j < dp[i].Count; j++)
    {
        if(i == 0 || j == 0)
        {
            dp[i][j] = 0;
        }
        else if (w[i] > j)
        {
            dp[i][j] = dp[i - 1][j];
        } 
        else if (i > 0 && j >= w[i])
        {
            dp[i][j] = Math.Max(v[i] + dp[i - 1][j - w[i]], dp[i - 1][j]);
        }
    }
}

foreach(var i in dp)
{
    foreach (var j in i)
    {
        Console.Write($"{j,5}");
    }
    Console.WriteLine();
}