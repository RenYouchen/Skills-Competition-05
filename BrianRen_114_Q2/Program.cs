//Read file
Console.Write("Enter 1st filename:");
var file1 = Console.ReadLine();
Console.Write("Enter 2st filename:");
var file2 = Console.ReadLine();

List<string> rawStr1 = File.ReadAllLines($"../../../{file1}").ToList();
// Console.WriteLine(string.Join('\n', rawStr1));

