while (true)
{
    int a,b;
    var s = Console.ReadLine();
    if(string.IsNullOrEmpty(s)) break;
    var input = s.Split(' ').Select(int.Parse).ToList();
    a = input[0];
    b = input[1];
    Console.WriteLine(FormatList(GetFactor(a), GetFactor(b), GCD(a,b)));
}

List<int> GetFactor(int n)
{
    List<int> factorList = new List<int>();

    while (n % 2 == 0)
    {
        factorList.Add(2);
        n /= 2;
    }

    for (int i = 3; i * i <= n; i += 2)
    {
        while (n % i == 0)
        {
            factorList.Add(i);
            n /= i;
        }
    }
    
    if(n > 2) factorList.Add(n);
    return factorList;
}

int GCD(int a, int b)
{
    if (a % b == 0) return b;
    return GCD(b, a % b);
}

char IsPrime(int n) => GetFactor(n).Count > 1 ? 'N' : 'Y';

string FormatList(List<int> input1, List<int> input2, int gcd) =>
    $"{string.Join(", ",new[] { input1, input2 }
        .Select(x => string.Join('*', x
            .GroupBy(f=>f)
            .Select(g => g.Count() > 1 ? $"{g.Key}^{g.Count()}" : $"{g.Key}"))))}, {gcd}, {IsPrime(gcd)}";
// { 
//     // return string.Join('*', input1
//     //     .GroupBy(f => f)
//     //     .Select(g => g.Count() > 1 ? $"{g.First()}^{g.Count()}" : $"{g.First()}")
//     // );
// }