while (true) {
    int a, b;
    //Console.WriteLine(Check(int.Parse(Console.ReadLine())));
    Console.Write("a=");
    try
    {
        a = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        break;
    }
    Console.Write("b=");
    b = int.Parse(Console.ReadLine());
    //a = 60; b = 48;
    Console.WriteLine(Calc(a));
    Console.WriteLine(Calc(b));
    Console.WriteLine($"GCD={GCD(a, b)}，是否為質數：{Check(GCD(a, b))}");
    //Console.ReadKey();    
}
Console.ReadKey();

int GCD(int a, int b)
{
    if(a==0) return b;
    return GCD(b % a, a);
}

string Calc(int n)
{
    //List<int> divNum = [2, 3, 5, 7, 11,13,17,19,23,29,31];
    List<string> ans = [];
    int rawN = n;
    int i = 2;
    //int i = 0;
    int count = 0;
    while(true)
    {
        //if (i == divNum.Count()) break;
        if (i >= rawN+2) 
            break;
        //int num = divNum[i];
        int num = i;
        (int,int) divRem = int.DivRem(n, num);
        
        if(divRem.Item2 != 0)
        {
            //if (count == 0) break;
            if(count==1)
            {
                ans.Add($"{num}");
            }
            else if(count != 0)
            {
                ans.Add($"{num}^{count}");
            }
            i++;
            count = 0;
        }
        if (divRem.Item2 == 0)
        {
            n = divRem.Item1;
            count++;
        }
        //if (n == 1) break;

    }
    //for(int i = 2; i < n; i++)
    //{
    //    int count = 1;
    //    while((double)n%(Math.Pow(i,count)) == 0)
    //        //while (n%i == 0)
    //    {
    //        n /= i;
    //        count++;
    //    }
    //    ans.Add($"{i}^{count}");
    //}
    return string.Join('*', ans);
}

string Check(int gcd)
{
    bool flag = false;
    if (gcd == 1)
    {
        return "否";
    }
    if (gcd == 2) 
    {
        return "是";
    }
    for (int i = 2; i < gcd; i++)
    {
        if (gcd % i == 0)
        {
            flag = true; break;
        }
    }
    return flag ? "否" : "是";
}