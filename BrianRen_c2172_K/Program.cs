//https://codeforces.com/contest/2172/problem/K

/*
9 8 4
4216793+
717*4*54
7+5+727*
45149+71
8+26697*
+189*2+9
5+*244+7
42595952
97+*315+
67
420
3
727
 */

using System.Data;

var inputString = Console.ReadLine()!.Split().Select(int.Parse).ToList();
int n = inputString[0],m = inputString[1],q = inputString[2];

List<List<char>> grid = new List<List<char>>();
List<string> searchNum = new List<string>();

for (int i = 0; i < n; i++)
    grid.Add(Console.ReadLine()!.ToList());

for(int i = 0; i < q; i++) 
    searchNum.Add(Console.ReadLine()!);

int[] offsetX = [-1, -1, -1, 0, 0, 1, 1, 1];
int[] offsetY = [-1, 0, 1, -1, 1, -1, 0, 1];
var dt = new DataTable();
// void GetNum(int startX, int startY, int endX, int endY)
// {
//     int result = grid[startX][startY] - '0';
//     if (startX == endX)
//     {
//         // result = grid[]
//     }
// }

// int GetNum(int startX, int startY, int pos)
// {
     // if (startX + offsetX[pos] < 0 || startX + offsetX[pos] > 0 || startY + offsetY[pos] < 0 ||
     //     startY + offsetY[pos] > 0)
     // {
     //     return -1;
     // }
//
//     return grid[startX + offsetX[pos]][startY + offsetY[pos]];
// }

void CalcNum(int startX, int startY, string s, int pos, string search)
{
    if (startX == n || startY == m)
    {
        Console.WriteLine(s);
        return;
    }

    if (s == search)
    {
        Console.WriteLine(search);
        return;
    }

    int res = int.Parse(search);
    if (res == Convert.ToInt32(dt.Compute(s, null)))
    {
        Console.WriteLine(res);
    }
    
    if (startX + offsetX[pos] < 0 ||
        startX + offsetX[pos] >= n ||
        startY + offsetY[pos] < 0 ||
        startY + offsetY[pos] >= m) return;
    // if (s.Length > 0)
    // {
        CalcNum(startX + offsetX[pos], startY + offsetY[pos], s+grid[startX][startY], pos, search);
    // }
    // else
    // {
    //     for (int i = 0; i < 8; i++)
    //     {
    //         if(pos == 9 - i) continue;
    //         CalcNum(startX + offsetX[i], startY + offsetY[i], s + grid[startX][startY], i,search);
    //     }
    // }
}
//
// for(int k = 0; k < 8; k++)
//     CalcNum(0, 0, "", k, "67");
     // CalcNum(0, 0, "", 0, "67");

foreach (var search in searchNum)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for(int k = 0; k < 8; k++)
                CalcNum(i, j, "", k, search);
        }
    }
}

