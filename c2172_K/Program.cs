// See https://aka.ms/new-console-template for more information

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

var curIdx = 0;
var numCount = new int[searchNum.Count];
var map = new Dictionary<int, int>();
for(int sIdx = 0; sIdx < searchNum.Count; sIdx++)
{
    curIdx = sIdx;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < 8; k++)
            {
                d(i,j, k, grid[i][j].ToString(), true);
            }
        }
    }
}
Console.WriteLine(string.Join('\n', numCount));

void d(int curX, int curY, int pos, string s, bool first)
{

    if (!first)
    {
        try
        {
            if (Convert.ToInt32(dt.Compute(s, null)).ToString() == searchNum[curIdx])
            {
                // Console.WriteLine($"Find {searchNum[curIdx]}");
                numCount[curIdx]++;
                return;
            }
        }
        catch (Exception e)
        {
        }
    }
    
    if (curX + offsetX[pos] < 0 ||
        curX + offsetX[pos] >= n ||
        curY + offsetY[pos] < 0 ||
        curY + offsetY[pos] >= m) return;
    d(curX + offsetX[pos], curY + offsetY[pos], pos, s + grid[curX + offsetX[pos]][curY + offsetY[pos]], false);
}