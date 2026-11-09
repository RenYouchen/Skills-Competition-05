while (true)
{
    Console.WriteLine("請輸入硬幣種類數 n（輸入0結束）：");
    var n = int.Parse(Console.ReadLine());
    if (n == 0) return;
    Console.WriteLine("請輸入硬幣面額（以空白分隔）：");
    var vn = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
    Console.WriteLine("請輸入 商品價格 與 付款金額（以空白分隔）：");
    var tmp = Console.ReadLine().Split().Select(int.Parse).ToList();

    var price = tmp[0];
    var pay = tmp[1];
    var change = pay - price;

    var dp = new int[change + 1];
    var last = new int[change + 1];

    int[] dpWays = new int[change+1];

    dpWays[0] = 1;
    foreach (var coin in vn)
        for (int j = coin; j < change+1; j++)
            dpWays[j] += dpWays[j - coin];

    dp[0] = 0;

    for (int i = 1; i <= change; i++)
    {
        dp[i] = int.MaxValue;
        foreach (var v in vn)
        {
            if (v <= i && dp[i - v] + 1 < dp[i])
            {
                dp[i] = dp[i - v] + 1;
                last[i] = v;
            }
        }
    }

    var combo = new List<int>();
    int cur = change;
    while (cur > 0)
    {
        combo.Add(last[cur]);
        cur -= last[cur];
    }

    Console.WriteLine("Total Ways = " + dpWays[change]);
    Console.WriteLine("MinCoins = " + dp[change]);
    Console.WriteLine("OneMinCombo = " + string.Join("*", combo));
    Console.WriteLine("-------------------------------------");
}