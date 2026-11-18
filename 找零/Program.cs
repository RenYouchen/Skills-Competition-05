// See https://aka.ms/new-console-template for more information

int[] coins = [2,3,5];
int n = 17;

var dp = new int[n + 1];
dp[0] = 1;
dp[1] = 0;

for (int i = 0; i <= n; i++)
{
    foreach (var coin in coins)
    {
        if(i - coin >= 0) 
            dp[i] += dp[i - coin];
    }   
}
Console.WriteLine(dp[n]);
