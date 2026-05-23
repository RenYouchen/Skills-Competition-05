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

List<List<int>> FlipHori(List<List<int>> input)
{
    List<List<int>> newBox = Enumerable.Range(0, 3).Select(_ => Enumerable.Repeat(0, 3).ToList()).ToList();
    newBox = input.Select(row => Enumerable.Reverse(row).ToList()).ToList();
    return newBox;
}
List<List<int>> FlipVec(List<List<int>> input)
{
    List<List<int>> newBox = Enumerable.Range(0, 3).Select(_ => Enumerable.Repeat(0, 3).ToList()).ToList();
    newBox = Enumerable.Reverse(input).ToList();
    return newBox;
}

List<List<int>> Transpose(List<List<int>> input)
{
    List<List<int>> newBox = Enumerable.Range(0, 3).Select(_ => Enumerable.Repeat(0, 3).ToList()).ToList();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            newBox[i][j] = input[j][i];
        }
    }
    return newBox;
}


List<List<int>> Rotate(List<List<int>> input, int times)
{
    if (times == 1)
    {
        return FlipHori(Transpose(input));
    }
    return Rotate(FlipHori(Transpose(input)), times-=1);
}

foreach (var i in box)
{
    Console.WriteLine(string.Join(' ', i));
}
Console.WriteLine("------ ori");
foreach (var i in FlipHori(box))
{
    Console.WriteLine(string.Join(' ', i));
}
Console.WriteLine("------fliphori");
foreach (var i in FlipVec(box))
{
    Console.WriteLine(string.Join(' ', i));
}
Console.WriteLine("------flipvec");
foreach (var i in Rotate(box, 2))
{
    Console.WriteLine(string.Join(' ', i));
}

Console.WriteLine("------transp");
foreach (var i in FlipHori(Transpose(box))) //TODO fixbug
{
    Console.WriteLine(string.Join(' ', i));
}
Console.WriteLine("------transp flip");
