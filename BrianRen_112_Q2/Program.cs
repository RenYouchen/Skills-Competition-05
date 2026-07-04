Console.Write("輸入原來的英文單字：");
string s1 = Console.ReadLine();
s1 = s1.Insert(0, " ");
Console.Write("輸入改變後的英文單字：");
string s2 = Console.ReadLine(); 
s2 = s2.Insert(0, " ");

int[,] dp = new int[s1.Length, s2.Length];

for (int i = 0; i < s1.Length; i++)
{
    for (int j = 0; j < s2.Length; j++)
    {
        // Console.WriteLine($"{i} {j}");
        if (i == 0 && j == 0) continue;
        if (i == 0)
        {
            dp[i,j] = dp[i,j - 1] + 1;
            continue;
        }
        if (j == 0)
        {
            dp[i,j] = dp[i - 1,j] + 1;
            continue;
        }
        dp[i,j] = Math.Min(
            Math.Min(dp[i-1,j] +1, dp[i,j-1]+1),
            dp[i-1,j-1] + (s1[i] == s2[j] ? 0 : 2)
        );
    }
}

Console.WriteLine($"編輯距離：{dp[s1.Length-1,s2.Length-1]}");