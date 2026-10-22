// See https://aka.ms/new-console-template for more information
/*
7
-2 5 3 -6 4 -8 6

6
1 -2 3 5 -3 2

6
0 -2 3 5 -1 2
 */

var n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).ToList();

var currentSum = 0;
var maxSum = int.MinValue;
(int, int) index = (0, 0);
int currentStart = 0;
for (int i = 0; i < a.Count; i++)
{
    if (a[i] > currentSum + a[i])
    {
        currentSum = a[i];
        currentStart = i;
    }
    else
        currentSum += a[i];
    if (currentSum > maxSum)
    {
        maxSum = currentSum;
        index.Item1 = currentStart;
        index.Item2 = i;
    }
}
Console.WriteLine(maxSum);
Console.WriteLine($"{index.Item1} {index.Item2}");