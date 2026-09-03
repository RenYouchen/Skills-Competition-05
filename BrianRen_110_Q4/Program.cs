using System.Text.Json;

List<List<int>> result = new List<List<int>>();

Console.Write("請輸入一個二維陣列：");
var rawInput = Console.ReadLine();
var map = JsonSerializer.Deserialize<int[][]>(rawInput);
Console.WriteLine("數字地圖:");
Console.WriteLine(string.Join('\n', map.Select(x=>$"\t[{string.Join(", ", x)}]")));
FindPath(map, 0, 0, []);

if (map.First().Length + map.Length >= 8)
{
    Console.WriteLine("所有路徑:");
    Console.WriteLine(string.Join("\n", result.Select(x=>$"\t[{string.Join(", ", x)}]")));
}
Console.Write("最小路徑: ");
Console.WriteLine($"[{string.Join(", ",result.OrderBy(x => x.Sum()).First())}]");
Console.WriteLine($"最小路徑和:  {result.OrderBy(x => x.Sum()).First().Sum()}");

void FindPath(int[][] grid, int x, int y, List<int> paths)
{
    int rows = grid.Length;
    int cols = grid.First().Length;

    if (x >= rows || y >= cols) return ;
    paths.Add(grid[x][y]);
    if (x == rows - 1 && y == cols - 1)
    {
        // Console.WriteLine($"[{string.Join(", ", paths)}]");
        result.Add([..paths]); // == result.Add(new List<int>(paths));
    }
    else
    {
        FindPath(grid, x, y + 1, paths);
        FindPath(grid, x + 1, y, paths);
    }
    paths.RemoveAt(paths.Count-1);
}