while (true)
{
    int n;
    Console.Write("輸入n=");
    try
    {
        n = int.Parse(Console.ReadLine());
    }
    catch
    {
        break;
    }

    Console.Write("排列為：");
    var a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
   
    var A = Enumerable.Range(1, n).ToList();
    a.Reverse();

    Stack<int> stack = new Stack<int>();
    while (A.Count != 0)
    {
        stack.Push(A.First());
        A.RemoveAt(0);
        while (true)
        {
            if (stack.Count > 0 && stack.Peek() == a.First())
            {
                a.Remove(stack.Pop());
            }
            else
            {
                break;
            }
        }
    }

    var output = stack.Count > 0 ?"NO!":"YES!";
    Console.WriteLine($"輸出結果：{output}");
}
Console.ReadKey();