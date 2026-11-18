// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());
dfs(1, 2, 3, n);

void dfs(int a, int b, int c, int n)
{
    if (n <= 0) return;
    
    dfs(a, c, b, n-1);
    Console.WriteLine($"{a} -> {c}");
    dfs(b, a, c, n - 1);
}

Console.WriteLine("最少步數，方法");