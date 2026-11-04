// See https://aka.ms/new-console-template for more information


int[] numbers = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];
string[] symbols = "M CM D CD C XC L XL X IX V IV I".Split();

while (true)
{
    Console.WriteLine("輸入");
    var input = Console.ReadLine();
    string output = "";
    if (int.TryParse(input, out var num))
    {
        for (int i = 0; i < 13; i++)
        {
            while (num >= numbers[i])
            {
                output += symbols[i];
                num -= numbers[i];
            }
        }
    }
    else
    {
        var map = new Dictionary<char, int>()
        {
            ['M'] = 1000,
            ['D'] = 500,
            ['C'] = 100,
            ['L'] = 50,
            ['X'] = 10,
            ['V'] = 5,
            ['I'] = 1
        };

        int total = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int cur = map[input[i]];
            if (i + 1 < input.Length && cur < map[input[i + 1]])
            {
                total -= cur;
            }
            else
            {
                total += cur;
            }
        }

        output = $"{total}";
    }
    Console.WriteLine("輸出");
    Console.WriteLine(output);
}