// Console.Write("步驟1，輸入第一個檔案名稱：");
// var file1 = File.ReadAllLines($"../../../{Console.ReadLine()}");
// var fileName1 = Console.ReadLine();
var fileName1 = "三1.txt";
var file1 = File.ReadAllLines($"../../../{fileName1}");
// Console.Write("步驟1，輸入第二個檔案名稱：");
// var file2 = File.ReadAllLines($"../../../{Console.ReadLine()}");
var fileName2 = "三2.txt";
var file2 = File.ReadAllLines($"../../../{fileName2}");

var input1 = file1.Select(x => x.Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()).ToList();
var input2 = file2.Select(x => x.Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()).ToList();

Console.WriteLine("步驟2，y軸投影（累計水平）：");
var projectY1 = input1.Select(x => x.Count(i=>i == 0)+1).ToList();
var projectY2 = input2.Select(x => x.Count(i=> i == 0)+1).ToList();
//提示1.為避免相除時分母為0，x 軸及y 軸的每一個元素的投影初始值都預設為1。（from題目）
Console.WriteLine($"{fileName1}：(座標元素/投影量)");
Console.WriteLine(string.Join(' ', Enumerable.Range(0,32).Select(x=>$"{x,2}")));
Console.WriteLine(string.Join(' ', projectY1.Select(x=>$"{x,2}")));

Console.WriteLine($"{fileName2}：(座標元素/投影量)");
Console.WriteLine(string.Join(' ', Enumerable.Range(0,32).Select(x=>$"{x,2}")));
Console.WriteLine(string.Join(' ', projectY2.Select(x=>$"{x,2}")));

Console.WriteLine("\tx軸投影（累計垂直）：");
var projectX1 = Enumerable.Range(0, input1[0].Count)
    .Select(i=>input1.Sum(x=>x[i] == 0 ? 1 : 0) + 1).ToList();
var projectX2 = Enumerable.Range(0, input2[0].Count)
    .Select(i=>input2.Sum(x=>x[i] == 0 ? 1 : 0) + 1).ToList();
Console.WriteLine($"{fileName1}：(座標元素/投影量)");
Console.WriteLine(string.Join(' ', Enumerable.Range(0,32).Select(x=>$"{x,2}")));
Console.WriteLine(string.Join(' ', projectX1.Select(x=>$"{x, 2}")));

Console.WriteLine($"{fileName2}：(座標元素/投影量)");
Console.WriteLine(string.Join(' ', Enumerable.Range(0,32).Select(x=>$"{x,2}")));
Console.WriteLine(string.Join(' ', projectX2.Select(x=>$"{x, 2}")));


var simuY = projectY1.Zip(projectY2, (x, y) => (double)Math.Min(x,y) / Math.Max(x,y)).ToList();
var simuX = projectX1.Zip(projectX2, (x, y) => (double)Math.Min(x,y) / Math.Max(x,y)).ToList();

Console.WriteLine("步驟3，y軸只兩個圖形各座標元素的相似度:(座標元素/相似度)");
Console.WriteLine(string.Join(' ', Enumerable.Range(0,16).Select(x=>$"{x,5}")));
Console.WriteLine(string.Join(' ', simuY[..16].Select(x => $"{x,5:F3}")));
Console.WriteLine(string.Join(' ', Enumerable.Range(16,16).Select(x=>$"{x,5}")));
Console.WriteLine(string.Join(' ', simuY[16..].Select(x => $"{x,5:F3}")));

Console.WriteLine("\tx軸之兩個圖形個座標元素的相似度:(座標元素/相似度)");
Console.WriteLine(string.Join(' ', Enumerable.Range(0,16).Select(x=>$"{x,5}")));
Console.WriteLine(string.Join(' ', simuX[..16].Select(x => $"{x,5:F3}")));
Console.WriteLine(string.Join(' ', Enumerable.Range(16,16).Select(x=>$"{x,5}")));
Console.WriteLine(string.Join(' ', simuX[16..].Select(x => $"{x,5:F3}")));

Console.WriteLine($"步驟4，求平均相似度:垂直投影:{simuX.Sum()/32:F3}，水平投影:{simuY.Sum()/32:F3}");

Console.WriteLine($"步驟5，2字元相似度:{simuX.Sum()/32 * simuY.Sum()/32:F5}");

// for (int i = 0; i < input1.Count; i++)
// {
//     for (int j = 0; j < input1[i].Length; j++)
//     {
//         Console.Write($"{input1[j][i]} ");
//     }
//     Console.WriteLine();
// }