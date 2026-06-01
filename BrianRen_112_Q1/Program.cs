Console.Write("輸入x1=");
int a = int.Parse(Console.ReadLine());
int flag = 0;
int count = 2;
int output = fmax(a) - fmin(a);
Console.WriteLine($"x{count}={fmax(a)}-{fmin(a)}={output}，");

while (flag != output)
{
    count++;
    flag = output; 
    Console.Write($"x{count}={fmax(output)}-{fmin(output)}=");
    output = fmax(output) - fmin(output);
    Console.Write($"{output}，");
    if(fmax(output) - fmin(output) == output)
    {
        Console.WriteLine($"黑洞數={output}");
        
        break;
    }    
    Console.WriteLine();
}



int fmin(int a)
{ 
    var b = a.ToString().ToList().Select(x=> int.Parse(x.ToString())).OrderBy(x=>x).ToList();
    if (b.Count == 4)
    {
        a = b[0] * 1000 + b[1] * 100 + b[2] * 10 + b[3] * 1;
    }
    else
    {
        a = b[0] * 100 + b[1] * 10 + b[2] * 1;
    }
    return a; 
}
int fmax(int a)
{ 
    var b = a.ToString().ToList().Select(x=> int.Parse(x.ToString())).OrderByDescending(x=>x).ToList();
    if (b.Count == 4)
    {
        a = b[0] * 1000 + b[1] * 100 + b[2] * 10 + b[3] * 1;
    }
    else
    {
        a = b[0] * 100 + b[1] * 10 + b[2] * 1;
    }
    return a;
}