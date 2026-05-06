//Read file

// Console.Write("Enter 1st filename:");
// var file1 = Console.ReadLine();
var file1 = "Large_1.txt";
// Console.Write("Enter 2st filename:");
// var file2 = Console.ReadLine();
var file2 = "Small_1.txt";

List<string> rawStr1 = File.ReadAllLines($"../../../{file1}").ToList();
List<string> rawStr2 = File.ReadAllLines($"../../../{file2}").ToList();
// Console.WriteLine(string.Join('\n', rawStr1));
Large l = new Large();
l.ParseLarge(rawStr1);

Small s = new Small();
s.PardeSmall(rawStr2);

if (s.hT <= l.h1)
{
    for (int i = l.PointTop1.Value.Item1; i < l.PointLeft1.Value.Item1; i++)
    {
        for (int j = l.PointLeft1.Value.Item2; j < l.PointTop1.Value.Item2;j++)
        {
            
            Console.Write(rawStr1[i][j]);
        }
        Console.WriteLine();
    }
}
else
{
    
}

Console.WriteLine("");

class Large
{
    public (int, int)? PointTop1;
    public (int, int)? PointTop2;
    public (int, int)? PointLeft1;
    public (int, int)? PointLeft2;

    public int h1 => Math.Abs(PointTop1.Value.Item1 - PointLeft1.Value.Item1);
    public int h2 => Math.Abs(PointLeft1.Value.Item1 - PointLeft2.Value.Item1);

    public void ParseLarge(List<string> str)
    {
        for (int i = 0; i < str.Count; i++)
        {
            for (int j = 0; j < str[i].Length; j++)
            {
                if (str[i][j] == 'H')
                {
                    PointTop1 = (i, j);
                    while (str[i][j] != '.') j++;
                    PointTop2 = (i, j);
                    break;
                }
            }

            if (PointTop1.HasValue) break;
        }

        for (int j = 0; j < str[0].Length; j++)
        {
            for (int i = 0; i < str.Count; i++)
            {
                if (str[i][j] == 'H')
                {
                    PointLeft1 = (i, j);
                    while (str[i][j] != '.') i++;
                    PointLeft2 = (i, j);
                    break;
                }
            }
            if (PointLeft1.HasValue) break;
        }
    }
}

class Small
{
    public int hT => Math.Abs(TopPoint.Value.Item1 - BottomLeftPoint.Value.Item1)+1;
    public (int, int)? TopPoint;
    public (int, int)? BottomLeftPoint;
    public (int, int)? BottomRightPoint;

    public void PardeSmall(List<string> str)
    {
        for (int i = 0; i < str.Count; i++)
        {
            for (int j = 0; j < str[i].Length; j++)
            {
                if (str[i][j] == 'O')
                {
                    TopPoint = (i, j);
                    break;
                }
            }
            if(TopPoint.HasValue) break;
        }
        
        for (int i = str.Count-1; i > 0; i--)
        {
            for (int j = 0; j < str[i].Length; j++)
            {
                if (str[i][j] == 'O')
                {
                    BottomLeftPoint = (i, j);
                    while (str[i][j] != '.') j++;
                    BottomRightPoint = (i, j);
                    break;
                }
            }
            if(BottomLeftPoint.HasValue) break;
        }
    }
}