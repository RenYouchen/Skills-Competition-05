// List<int> randNums = Enumerable.Range(1,39).OrderBy(_=>new Random().Next()).ToList()[..5];
List<int> randNums = [4,28,11,38,2];

Console.WriteLine("***模擬今彩539***");
Console.WriteLine($"今彩539之5個1~39號碼: {string.Join(' ', randNums)}");
Console.Write("請輸入今彩539之5個號碼的檔名:");
string file_name = Console.ReadLine();

using (StreamWriter sw = new StreamWriter($"../../../{file_name}"))
{
    sw.WriteLine(string.Join(' ', randNums));
}

Console.Write("請輸入要讀今彩539之5個號碼的檔名: ");
file_name = Console.ReadLine();
using (StreamReader sr = new StreamReader($"../../../{file_name}"))
{
    randNums = sr.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
}

Console.WriteLine($"今彩539之5個號碼的算術平均數: {randNums.Average():F6}");
double h = 5.0 / randNums.Sum(x => 1.0/x);
Console.WriteLine($"今彩539之五個號碼的調和平均數: {h:F6}");
double g = Math.Pow(randNums.Aggregate((acc,x) => acc = x*acc), 1.0/5.0);
Console.WriteLine($"今彩539之五個號碼的幾何平均數: {g:F6}");
