// See https://aka.ms/new-console-template for more information
//0910093093
//Pa$$w0rd
//012345678901234567890123456789012345678911234567890123456789012345678901234567890123456789012345678901234567890123456789Pa$$w0rd
Console.Write("請輸入密碼：");
var password = Console.ReadLine();
var symbol = "!@#$%^&*()-+_=";
Console.WriteLine($"密碼長度：{password.Length}");
Console.WriteLine($"大寫英文字母長度：{password.Count(char.IsUpper)}");
Console.WriteLine($"小寫英文字母長度：{password.Count(char.IsLower)}");
Console.WriteLine($"數字長度：{password.Count(char.IsDigit)}");
Console.WriteLine($"符號長度：{password.Count(symbol.Contains)}");
int temp = 0;
temp += password.Any(char.IsUpper) ? 1 : 0;
temp += password.Any(char.IsLower) ? 1 : 0;
temp += password.Any(char.IsDigit) ? 1 : 0;
temp += password.Any(symbol.Contains) ? 1 : 0;

Console.WriteLine(password.Length >= 8 && password.Length <= 128 && temp >= 3 ? "符合密碼規則" : "不符密碼規則");