// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

//(a,c,b) (b,a,c)

void henei(int a, int b, int c, int n)
{
    if(n <= 0) return;
    henei(a,c,b,n - 1);
    Console.WriteLine($"{a}->{c}");
    henei(b,a,c, n - 1);
}
henei(1,2,3,n);