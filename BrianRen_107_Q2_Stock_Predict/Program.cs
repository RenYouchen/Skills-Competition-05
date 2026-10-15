// See https://aka.ms/new-console-template for more information

Console.Write("Input File:");
var file = File.ReadAllLines($"../../../Q2_data{Console.ReadLine()}.txt")
    .Select(x=>x.Split().Select(double.Parse).ToList()).ToList();
Console.WriteLine("最高價：");
Console.WriteLine(string.Join(" ", file[0]));
Console.WriteLine("收盤價：");
Console.WriteLine(string.Join(" ", file[1]));
Console.WriteLine("最低價：");
Console.WriteLine(string.Join(" ", file[2]));
var PDM = file[0].Zip(file[0].Skip(1), (d, d1) => Math.Max(d1 - d, 0)).ToList();
var MDM = file[2].Zip(file[2].Skip(1), (d, d1) => Math.Max(d - d1,0)).ToList();

for (int i = 0; i < PDM.Count; i++)
{
    if (PDM[i] < MDM[i]) PDM[i] = 0;
    else if (PDM[i] > MDM[i]) MDM[i] = 0;
    else PDM[i] = MDM[i] = 0;
}

var mAvPDM = Enumerable.Range(0, PDM.Count - 9)
    .Select(i => PDM.Skip(i).Take(10).Average()).ToList();
var mAvMDM = Enumerable.Range(0, MDM.Count - 9)
    .Select(i => MDM.Skip(i).Take(10).Average()).ToList();

var TR = Enumerable.Range(1, file[0].Count-1)
    .Select(i => (Math.Max(Math.Abs(file[0][i] - file[2][i]), Math.Max(Math.Abs(file[0][i] - file[1][i - 1]), Math.Abs(file[2][i] - file[1][i - 1])))))
    .ToList();
var mAvTR = Enumerable.Range(0, TR.Count - 9)
    .Select(i => TR.Skip(i).Take(10).Average()).ToList();

var PDI = mAvPDM.Zip(mAvTR, (a, b) => a / b).ToList();
var MDI = mAvMDM.Zip(mAvTR, (a, b) => a / b).ToList();

var DX = PDI.Zip(MDI, (a, b) => a + b == 0 ? 0 : 100 * Math.Abs(a - b) / (a + b)).ToList();
var ADX = Enumerable.Range(0, DX.Count - 9)
    .Select(i => DX.Skip(i).Take(10).Average()).ToList();
var predict = ADX.Zip(ADX.Skip(1), (a,b) => b >= a? 1 : 0);
Console.WriteLine("ADX:\t" + string.Join('\t', ADX.Skip(1).Select(x=>$"{x:F2}")));
Console.WriteLine("預測:\t" + string.Join("\t",predict));

