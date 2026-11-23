// See https://aka.ms/new-console-template for more information

/*
7 6
255 0 255 0 255 0
0 255 255 0 255 255
0 0 255 0 0 0
255 0 0 0 255 0
255 255 0 255 0 255
255 255 0 0 0 0
255 0 255 0 0 0
 */
 
var hw = Console.ReadLine().Split().Select(int.Parse).ToList();

int h = hw[0], w = hw[1];

List<List<int>> grid = new List<List<int>>();
for(int i = 0; i < h; i++)
 grid.Add(Console.ReadLine().Split().Select(int.Parse).ToList());

int[] offsetX = [-1, -1, -1, 0];
int[] offsetY = [-1, 0, 1, -1];
var parent = new List<int> { 0 };

int Find(int x)
{
 while (parent[x] != x) x = parent[x];
 return x;
}

for (int i = 0; i < h; i++)
{
 for (int j = 0; j < w; j++)
 {
  int cur = grid[i][j];
  List<int> hasLabel = [];

  if (cur == 0) continue;
  for (int k = 0; k < 4; k++)
  {
   if (i + offsetX[k] < 0 || i + offsetX[k] >= h || j + offsetY[k] < 0 || j + offsetY[k] >= w) continue;
   if (grid[i + offsetX[k]][j + offsetY[k]] != 0)
   {
    hasLabel.Add(grid[i + offsetX[k]][j + offsetY[k]]);
   }
  }

  if (hasLabel.Count == 0)
  {
   grid[i][j] = parent.Count;
   parent.Add(parent.Count);
  }
  else
  {
   int m = hasLabel.Min();
   grid[i][j] = m;
   foreach (var l in hasLabel)
   {
    int a = Find(l), b = Find(m);
    if (a != b) parent[Math.Max(a, b)] = parent[Math.Min(a, b)];
   }
  }
 }
}

for(int i = 0; i < h; i++)
for(int j = 0; j < w; j++)
 if (grid[i][j] != 0) grid[i][j] = Find(grid[i][j]);

for(int i = 0; i < h; i++)
Console.WriteLine(string.Join(' ', grid[i]));