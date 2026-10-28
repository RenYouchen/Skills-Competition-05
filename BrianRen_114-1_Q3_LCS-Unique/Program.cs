// See https://aka.ms/new-console-template for more information
var a = Console.ReadLine();
var b = Console.ReadLine();

int n = a.Length, m = b.Length;
var dp = new int[n+1,m+1];

for (int i = 1; i <= n; i++)
    for (int j = 1; j <= m; j++)
        dp[i, j] = a[i - 1] == b[j - 1]
            ? dp[i - 1, j - 1] + 1
            : Math.Max(dp[i, j - 1], dp[i - 1, j]);

var result = new HashSet<string>();

var s = "";
int x = n, y = m;
while (x > 0 && y > 0)
{
    if (a[x-1] == b[y-1])
    {
        s = a[x-1] + s;
        x--;
        y--;
    } 
    else if (dp[x - 1, y] >= dp[x, y - 1]) x--;
    else y--;
}
Console.WriteLine(dp[n,m]);
Console.WriteLine(s);
// void Back(int i, int j, string s)
// {
//     if (i == 0 || j == 0)
//     {
//         result.Add(s);
//         return;
//     }
//     if(a[i-1] == b[j-1]) 
//         Back(i-1, j-1, a[i-1] + s);
//     else
//     {
//         if(dp[i-1,j] == dp[i,j]) Back(i-1, j, s);
//         if(dp[i,j-1] == dp[i,j]) Back(i, j-1, s);
//     }
// }
// Back(n,m, "");
// Console.WriteLine(dp[n,m]);
// Console.WriteLine(result.OrderBy(s=>s, StringComparer.Ordinal).First());