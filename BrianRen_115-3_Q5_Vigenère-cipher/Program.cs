// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.WriteLine("輸入模式：");
    var mode = Console.ReadLine();
    Console.WriteLine("輸入金鑰：");
    var key = Console.ReadLine();
    Console.WriteLine("輸入明文/密文：");
    var word = Console.ReadLine();
    Console.WriteLine("輸出結果：");

    string output = "";
    if (mode == "E")
    {
        for (int i = 0; i < word.Length; i++)
        {
            int keyIdx = i % key.Length;
            int shift = key[keyIdx] - 'A';
            output += (char)((word[i] - 'A' + shift) % 26 + 'A');
        }
    } else if (mode == "D")
    {
        for (int i = 0; i < word.Length; i++)
        {
            int keyIdx = i % key.Length;
            int shift = 26 - (key[keyIdx] - 'A');
            output += (char)((word[i] - 'A' + shift) % 26 + 'A');
        }
    }
    
    Console.WriteLine(output);
}