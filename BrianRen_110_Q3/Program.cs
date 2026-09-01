using System.Numerics;

BigInteger[] bigIntegers = new BigInteger[92];

bigIntegers[0] = 1;
bigIntegers[1] = 1;

for (int i = 2; i < bigIntegers.Length; i++) bigIntegers[i] = bigIntegers[i - 1] + bigIntegers[i - 2];

for (int i = 0; i < bigIntegers.Length; i++) Console.WriteLine($"{i+1} {bigIntegers[i]}");

Console.Write("請從費式數列(Fibonacci Sequence)中選擇第1個數:");
int a = int.Parse(Console.ReadLine()) - 1;
Console.WriteLine($"您選擇第 {a} 式費式數列(Fibonacci Sequence): {bigIntegers[a], 30}");
Console.Write("請從費式數列(Fibonacci Sequence)中選擇第2個數:");
int b = int.Parse(Console.ReadLine()) - 1;
Console.WriteLine($"您選擇第 {b} 式費式數列(Fibonacci Sequence): {bigIntegers[b], 30}");
Console.WriteLine($"兩個費式數列(Fibonacci Sequence) 相加結果為: {bigIntegers[a]+bigIntegers[b], 30}");