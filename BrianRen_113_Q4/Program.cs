using System.Text.Json.Nodes;

var json = JsonNode.Parse(File.OpenRead("../../../huffman.json")).AsObject();

Console.Write("請輸入內文為英文的檔名(.txt): ");
var fileName = Console.ReadLine();

Console.WriteLine(fileName + " 的檔案內容:");
var fileContent = File.ReadAllText($"../../../{fileName}");
Console.WriteLine(fileContent);

Console.WriteLine("壓縮後的編碼:");
var bytes = "";
foreach (var i in fileContent)
{
    JsonNode node;
    json.TryGetPropertyValue($"{i}", out node);
    bytes += node.GetValue<string>();
}

for (int i = 0; i < bytes.Length; i++)
{
    Console.Write(bytes[i]);
    if((i+1)%8==0) Console.Write(" ");
}
Console.WriteLine();

if (bytes.Length % 8 != 0)
{
    bytes += new string[]
    {
        "0", "00", "000", "1110", "11110", "111101", "1111010"
    }[8-bytes.Length%8-1];
}
Console.WriteLine($"壓縮比:{(float)bytes.Length/8/fileContent.Length:F2}");
Console.WriteLine($"壓縮後檔案名稱: {fileName.Replace("txt", "bin")}");

byte[] outByte = Enumerable.Range(0, bytes.Length / 8)
    .Select(x => bytes.Substring(x * 8, 8))
    .Select(bin => Convert.ToByte(bin, 2))
    .ToArray();

File.WriteAllBytes(fileName.Replace("txt", "bin"), outByte);
Console.WriteLine("存入壓縮檔的編碼:");
for (int i = 0; i < bytes.Length; i++)
{
    Console.Write(bytes[i]);
    if((i+1)%8==0) Console.Write(" ");
}
