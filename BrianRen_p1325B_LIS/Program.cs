// See https://aka.ms/new-console-template for more information

int t = int.Parse(Console.ReadLine());	
while((t--) > 0) 
{
    // int n = int.Parse(Console.ReadLine());
    //
    // var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
    //
    // var nums = Array.Empty<int>();
    // for(int i = 0; i < n; i++)
    // {
    //     nums = nums.Concat(a).ToArray();
    // }
    //
    // var dp = new int[nums.Length];
    // for (int i = 0; i < nums.Length; i++)
    //     dp[i] = 1;
    //
    // for(int i = 1; i < nums.Length; i++) 
    //     for(int j = 0; j < i; j++)
    //         if (nums[i] > nums[j])
    //             dp[i] = Math.Max(dp[i], dp[j] + 1);
    //
    // Console.WriteLine(dp.Max());
    Console.ReadLine();
    Console.WriteLine(Console.ReadLine().Split().Distinct().Count());
}