var s = "";
Stack<(int, int)> stack = new Stack<(int, int)>();
//[0] == in time, [1] == out time
while ((s = Console.ReadLine()) != "")
{
    var input = s.Split(' ').Select(int.Parse).ToList();
    if (stack.Count == 0 || input[0] >= stack.Peek().Item2 || stack.Peek().Item2 >= input[1])
    {
        stack.Push((input[0],input[1]));
    }
}
Console.WriteLine(stack.Count);

// input[0] <=stack.Peek().Item1


