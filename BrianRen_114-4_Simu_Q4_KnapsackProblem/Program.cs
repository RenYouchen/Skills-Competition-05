// See https://aka.ms/new-console-template for more information

/*
10
4
聖杯 3 10
王冠 4 15
寶石 2 8
金幣 5 18
 */

int w = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
var data = new List<List<string>>();
for (int i = 0; i < n; i++) 
    data.Add(Console.ReadLine().Split().ToList());
(string, int)[,] dp = new(string,int)[n+1,w+1];
for (int i = 1; i <= n; i++) //item
{ 
    for (int j = 1; j <= w; j++) //weight
    {
        string name = data[i - 1][0];
        int weight = int.Parse(data[i-1][1]);
        int value = int.Parse(data[i-1][2]);

        if (weight > j)
        {
            dp[i, j] = dp[i - 1, j];
        }
        else
        {
            // dp[i, j] = new[] { dp[i-1, j], (i, dp[i - 1, j - weight].Item2 + value)}.MaxBy(x=>x.Item2);
            dp[i, j] = new[]
                    { dp[i - 1, j], ( $"{dp[i-1,j-weight].Item1} {name}", dp[i - 1, j - weight].Item2 + value) }
                .MaxBy(x => x.Item2);
        }
    }
}

var dict = data.ToDictionary(d => d[0], d => int.Parse(d[2]));

var items = (dp[n, w].Item1 ?? "")
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .OrderByDescending(x => dict[x])
    .ToList();

// for (int i = n; i > 0; i--)
// {
//     for (int j = w; j > 0; j--)
//     {
//         if (dp[i - 1, j] != dp[i, j])
//         { 
//             Console.WriteLine(dp[i,j]);
//             
//         }
//     }
// }
Console.WriteLine(dp[n,w].Item2);
Console.WriteLine(string.Join('\n', items));