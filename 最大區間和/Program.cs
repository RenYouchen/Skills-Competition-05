// See https://aka.ms/new-console-template for more information

int sum = 0;
int[] arr = [-5,-4,-2];
// arr = [1,2,-3,4,5,-6,7];
int idxL = -1, idxR = -1;
int prevL = -1;
int max = int.MinValue;
for (int i = 0; i < arr.Length; i++)
{
    if (sum < 0)
    {
        prevL = i+1;
        sum = 0;
    }
    sum += arr[i];
    if (sum > max)
    {
        max = sum;
        idxL = prevL;
        idxR = i;
    }
}
Console.WriteLine((idxL, idxR));
Console.WriteLine(sum);