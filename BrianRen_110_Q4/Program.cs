using System.Text.Json;

Console.Write("請輸入一個二維陣列：");
var rawInput = Console.ReadLine();
var map = JsonSerializer.Deserialize<int[][]>(rawInput);
Console.WriteLine(string.Join('\n', map.Select(x=>$"[{string.Join(", ", x)}]")));

List<List<int>> Parse(string input)
{
    List<List<int>> map = new List<List<int>>();
    
    
    return map;
}