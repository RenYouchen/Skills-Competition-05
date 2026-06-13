Console.WriteLine("請輸入IoU閾值(0, 1]，例如0.5或0.8（輸入無效值將使用預設值0.5）：");
Console.Write("IoU閾值：");

decimal v;
if(!decimal.TryParse(Console.ReadLine(), out v))
{
    Console.WriteLine("無效值將使用預設值0.5");
    v = 0.5m;
} 
if(v <= 0 || v > 1)
{
    Console.WriteLine("無效值將使用預設值0.5");
    v = 0.5m;
}

Console.WriteLine($"IoU 閾值={v:F2}");
var boxs = File.ReadLines("..\\..\\..\\boxes.txt")
    .Select(line => line.Split(' ').Select(decimal.Parse).ToList())
    .Select(x => new Box(x[0], x[1], x[2], x[3], x[4], x[5]))
    .ToList();

var output = new List<Box>();
while (boxs.Any())
{
    var box = boxs.First(); 
    boxs.RemoveAt(0);

    var fuse = new List<Box>();

    foreach(var b in boxs)
    {
        if(IoU(box, b) >= v)
        {
            fuse.Add(b);
        }
    }
    
    if(!fuse.Any())
    {
        output.Add(box);
        continue;
    }

    fuse.Add(box);
    foreach(var b in fuse)
    {
        boxs.Remove(b);
    }
    output.Add(Fusion(fuse));
}

Console.WriteLine($"融合后的框數量{output.Count}");

for(int i = 0; i < output.Count; i++)
{
    Console.WriteLine($"框{i+1}: {output[i]}");
}


try
{
    using (StreamWriter sw = new StreamWriter("..\\..\\..\\fused_boxes.txt"))
    {
        sw.WriteLine($"IoU Threshold{v:f2}");
        sw.WriteLine($"Number of Fused Boxes: {output.Count}");

    }
}
catch
{
    Console.WriteLine("無法輸出檔案");
}


decimal IoU(Box b1, Box b2)
{
    decimal IoU = 0m;
    var x1 = Math.Max(b1.x1, b2.x1);
    var y1 = Math.Max(b1.y1, b2.y1);
    var x2 = Math.Min(b1.x2, b2.x2);
    var y2 = Math.Min(b1.y2, b2.y2);

    var width = Math.Max(0, x2 - x1);
    var height = Math.Max(0, y2 - y1);

    decimal intersection = width*height;
    decimal union = b1.Area + b2.Area - intersection;
    IoU = intersection / union;
    return IoU;
}

Box Fusion(List<Box> list)
{
    decimal x1 = 0m, y1 = 0m, x2 = 0m, y2 = 0m, score = 0m, weight = 0m;
    foreach(Box b in list)
    {
        x1 += b.x1 * b.weight;
        x2 += b.x2 * b.weight;
        y1 += b.y1 * b.weight;
        y2 += b.y2 * b.weight;
        score += b.score * b.weight;
        weight += b.weight; 
    }

    return new Box(
            x1 / weight,
            y1 / weight,
            x2 / weight,
            y2 / weight,
            score / weight,
            weight
        );
}
record Box(decimal x1, decimal y1, decimal x2, decimal y2, decimal score, decimal weight)
{
    public decimal Area => (x2-x1)*(y2-y1);
    public override string ToString()
    {
        return $"x1={x1:F2}, y1={y1:F2}, x2={x2:F2}, y2={y2:F2}, score={score:F2}, weight={weight:F2}";
    }
}