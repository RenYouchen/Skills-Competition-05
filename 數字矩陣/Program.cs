// See https://aka.ms/new-console-template for more information
//Q3
/*
3
4
C 1 1
D
A 1 1
R
   
 */
using System.Runtime.CompilerServices;

int n = int.Parse(Console.ReadLine());
int step = int.Parse(Console.ReadLine());

int[,] grid = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        grid[i, j] = i * n + j + 1;
    }
}

(int,int)cur = (0,0);
int sum = 1;
for (int i = 0; i < step; i++)
{
    var cmd = Console.ReadLine().Split();
    switch (cmd[0])
    {
        case "U" :
            if (Check(cur.Item1 - 1, cur.Item2))
            {
                cur = (cur.Item1 - 1, cur.Item2);
                sum += grid[cur.Item1, cur.Item2];
            }
            break;
        case "D":
            if (Check(cur.Item1+1, cur.Item2))
            {
                cur = (cur.Item1 + 1, cur.Item2);
                sum += grid[cur.Item1, cur.Item2];
            }
            break;
        case "L":
            if (Check(cur.Item1, cur.Item2 - 1))
            {
                cur = (cur.Item1, cur.Item2 - 1);
                sum += grid[cur.Item1, cur.Item2];
            }
            break;
        case "R":
            if (Check(cur.Item1, cur.Item2 + 1))
            {
                cur = (cur.Item1, cur.Item2 + 1);
                sum += grid[cur.Item1, cur.Item2];
            }
            break;
        case "C":
            int a = int.Parse(cmd[1])-1;
            int b = int.Parse(cmd[2])-1;
            Crc(a,b);
            break;
        case "A":
            int c = int.Parse(cmd[1])-1;
            int d = int.Parse(cmd[2])-1;
            Arc(c,d);
            break;
    }
}

Console.WriteLine(sum);
Console.WriteLine($"{cur.Item1 + 1} {cur.Item2 + 1}");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
       Console.Write(grid[i,j] + " ");
    }
    Console.WriteLine();
}

bool Check(int i, int j)
{
    if (i < 0 || i >= n || j < 0 || j >= n) return false;
    else return true;
}

void Crc(int x, int y)
{
    if (cur.Item1 == x && cur.Item2 == y)
    {
        cur = (x, y + 1);
    }
    else if (cur == (x, y + 1))
    {
        cur = (x + 1, y + 1);
    }
    else if (cur == (x+1, y+1))
    {
        cur = (x+1, y);
    }
    else if (cur == (x+1, y))
    {
        cur = (x, y);
    }
    
    int a = grid[x, y];
    int b = grid[x, y + 1];
    int c = grid[x + 1, y + 1];
    int d = grid[x + 1, y];

    grid[x, y] = d;
    grid[x, y + 1] = a;
    grid[x + 1, y + 1] = b;
    grid[x + 1, y] = c;
}

void Arc(int x, int y)
{
    if (cur == (x,y))
    {
        cur = (x+1, y);
    }
    else if (cur == (x, y + 1))
    {
        cur = (x, y);
    }
    else if (cur == (x+1, y+1))
    {
        cur = (x, y+1);
    }
    else if (cur == (x+1, y))
    {
        cur = (x+1, y+1);
    }
    
    int a = grid[x, y];
    int b = grid[x, y + 1];
    int c = grid[x + 1, y + 1];
    int d = grid[x + 1, y];

    grid[x, y] = b;
    grid[x, y + 1] = c;
    grid[x + 1, y + 1] = d;
    grid[x + 1, y] = a;
}