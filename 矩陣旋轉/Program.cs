// See https://aka.ms/new-console-template for more information

//n,m grid, CW, CCW

/*
3 3
1 2 3
4 5 6
7 8 9
CW

3 4
1 2 3 4
5 6 7 8
9 10 11 12
CCW
 */

var a = Console.ReadLine().Split().Select(int.Parse).ToList();
int n = a[0], m = a[1];

int max = Math.Max(n, m);
string[,] grid = new string[max,max];

for (int i = 0; i < n; i++)
{
    var s = Console.ReadLine().Split();
    for (int j = 0; j < m; j++)
    {
        grid[i, j] = s[j];
    }
}

switch (Console.ReadLine())
{
    case "CW":
        Transform();
        HorFlip();
        break;
    case "CCW":
        Transform();
        VerFlip();
        break;
    default:
        break;
}

void Transform()
{
    var a = new string[max, max];
    for (int i = 0; i < max; i++)
    for (int j = 0; j < max; j++)
        a[i, j] = grid[j, i];
    grid = a;
}

void VerFlip()
{
    var a = new string[max, max];
    for (int i = 0; i < max; i++)
    for (int j = 0; j < max; j++)
        a[i, j] = grid[max - i - 1, j];
    grid = a;

}

void HorFlip()
{
    var a = new string[n, m];
    for (int i = 0; i < n; i++)
    for (int j = 0; j < m; j++)
        a[i, j] = grid[i, max-j-1];
    grid = a;
}

for (int i = 0; i < max; i++)
{
    for (int j = 0; j < max; j++)
    {
        // if(grid[i,j] == "") continue;
        Console.Write(grid[i,j] + " ");
    }
    Console.WriteLine();
}
