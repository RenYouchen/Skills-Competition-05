string raw;
while ((raw = Console.ReadLine()) != "")
{
    int n = int.Parse(raw);
    string rawInput;
    while ((rawInput = Console.ReadLine()) != "0")
    {
        List<int> inputs = rawInput.Split(' ').Select(int.Parse).Reverse().ToList();
        Stack<int> towerB = new Stack<int>();
        List<int> nums = Enumerable.Range(1, n).ToList();
        for (int i = 0; i < n; i++)
        {
            towerB.Push(nums[i]);
            while (towerB.Count != 0)
            {
                if (towerB.Peek() != inputs[0])
                {
                    break;
                }
                else
                {
                    inputs.Remove(towerB.Pop());
                }
            }
        }
        Console.WriteLine(towerB.Count==0?"YES!":"NO!");
    } 
}