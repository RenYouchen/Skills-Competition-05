List<List<int>> box = Enumerable.Range(0, 3).Select(_ => Enumerable.Repeat(0, 3).ToList()).ToList();
int x = 0;
int y = 1;

for (int i = 1; i <= 9; i++)
{
    box[x][y] = i;
    ChangePos(ref x, ref y);
}



void ChangePos(ref int x, ref int y)
{
    int oldX = x;
    int oldY = y;
    
    x -= 1;
    y += 1;
    
    if ((x>=0 && x <=2 && y>=0 && y<=2 && box[x][y] != 0) || (x < 0 && y > 2))
    {
        x = oldX+1;
        y = oldY;
    }
    if (x < 0)
    {
        x = 2;
    } 
    if (y > 2)
    {
        y = 0;
    }
}

foreach (var i in box)
{
    Console.WriteLine(string.Join(' ', i));
}