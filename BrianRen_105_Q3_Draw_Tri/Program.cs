// See https://aka.ms/new-console-template for more information

Point p1 = new Point(5, 5), p2 = new Point(24, 17);
List<Point> points = new List<Point>();




string s;
while ((s = Console.ReadLine()) != null && s.Trim() != "")
{
    var a = s.Split(' ').Select(int.Parse).ToList();
    points.Add(new Point(a[0], a[1]));
}

int maxX = points.MaxBy(x=>x.x).x;
int maxY = points.MaxBy(x=>x.y).y;

char[,] canva = new char[maxX + 1, maxY + 1];
for (int i = 0; i < canva.GetLength(0); i++)
for (int j = 0; j < canva.GetLength(1); j++)
    canva[i, j] = ' ';

for (int i = 0; i < points.Count; i++)
{
    for (int j = 0; j < points.Count; j++)
    {
        DrawLine(points[i], points[j]);
    }
}


void DrawLine(Point p1, Point p2)
{
    double m = (double)(p2.y - p1.y) / (p2.x - p1.x);
    if (p1.x == p2.x)
    {
        for (int i = p1.y; i < p2.y; i++)
        {
            canva[p1.x, i] = '*';
        }
    }
    else
    {
        for (int i = p1.x; i < p2.x; i++)
        {
            var y = (int)(m * (i - p1.x) + p1.y);
            canva[i, y] = '*';
        }
    }
}

int col = canva.GetLength(1);
int row = canva.GetLength(0);
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        Console.Write(canva[row - i - 1, j]);
    }
    Console.WriteLine();
}

record Point(int x, int y);