// See https://aka.ms/new-console-template for more information
string s;
while((s = Console.ReadLine()) != null)
{
    var a = s.Split().Select(double.Parse).ToList();
    var water = a[0] switch
    {
        < 50 => 1,
        >= 50 and <= 100 => 2,
        > 100 => 3
    };
    var elect = a[1] switch
    {
        < 100 => 1,
        >= 100 and <= 200 => 2,
        > 200 => 3
    };
    if (water == 1 && elect == 1)
    {
        Console.WriteLine(Math.Round((a[0] + a[1]) / 2 * 0.6 * 5,0));
    }
    else if ((water == 1 && elect == 2) || (water == 2 && elect == 1)) 
    {
        Console.WriteLine(Math.Round((a[0] + a[1]) / 2 * 0.8 * 5,0));
    }
    else if ((water == 3 && elect == 2) || (water == 2 && elect == 3))
    {
        Console.WriteLine(Math.Round((a[0] + a[1]) / 2 * 1.2 * 5, 0));
    }
    else if ((water == 3 && elect == 3))
    {
        Console.WriteLine(Math.Round((a[0] + a[1]) / 2 * 1.4 * 5, 0));
    }
    else
    {
        Console.WriteLine(Math.Round((a[0] + a[1]) / 2 * 5, 0));
    }

}


Console.ReadKey();