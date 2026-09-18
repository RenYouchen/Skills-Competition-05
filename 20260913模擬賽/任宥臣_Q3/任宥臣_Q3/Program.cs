while(true)
{
    int N;
    Console.Write("N=");
    try
    {
        N = int.Parse(Console.ReadLine());
    } 
    catch
    {
        break;
    }
    Console.Write("陣列為：");
    List<int> a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

    int curSum = a[0];
    int curStart = 0;
    int maxSum = a[0];
    int ansStart = 0;
    int ansEnd = 0;
    for(int i = 1; i < a.Count; i++)
    {
        if(curSum <= 0)
        {
            curSum = a[i];
            curStart = i;
        } 
        else
        {
            curSum = curSum + a[i];
        }
        if(curSum> maxSum)
        {
            maxSum = curSum;
            ansStart = curStart;
            ansEnd = i;
        }
    }
    Console.WriteLine($"{maxSum}\n{ansStart} {ansEnd}");

}
//7
//-2 5 3 -6 4 -8 6
Console.ReadKey();