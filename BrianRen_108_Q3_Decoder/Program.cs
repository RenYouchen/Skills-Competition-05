// See https://aka.ms/new-console-template for more information

List<int> input = Console.ReadLine().Split().Select(x => Convert.ToInt32(x, 16)).ToList();
var hArray = new List<int>(){0xabcd, 0xcdef, 0x2266, 0xceed, 0xaccd};

input = input.Zip(hArray, ((a, b) => a - b)).ToList();
int[] word = new int[5];
for (int i = 0; i <= 4; i++)
{
    int temp = input[0];
    input[0] = input[1];
    input[1] = input[2];
    input[2] = input[3];
    input[3] = input[4];
    input[4] = hArray[i];
    int a = temp - 4 * input[0] - input[1] - input[2] - input[4] - 0x5a82;
    word[i] = Convert.ToInt32(a + ' ');
}
Console.WriteLine(string.Join("", word.Reverse().Select(x=> (char)x)));
