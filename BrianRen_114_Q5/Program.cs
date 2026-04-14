float IoU;

Box Fusion(List<Box> boxes)
{
    float x1 = 0, x2 = 0, y1 = 0, y2 = 0, score = 0, totalWeight = 0;
    foreach (var b in boxes)
    {
        x1 += b.x1 * b.weight;
        x2 += b.x2 * b.weight;
        y1 += b.y1 * b.weight;
        y2 += b.y2 * b.weight;
        score += b.score * b.weight;
        totalWeight += b.weight;
    }

    return new Box(
        x1/totalWeight,
        y1/totalWeight,
        x2/totalWeight,
        y2/totalWeight,
        score/totalWeight,
        totalWeight
    );
}


//（Intersection over Union, IoU）
//甲、IoU = 交集面積 / 聯集面積。
//乙、交集面積：計算兩個框重疊矩形的面積，若無重疊則為 0
//丙、聯集面積：兩個框面積之和減去交集面積。
//https://web.ntnu.edu.tw/~algo/Shape.html ntnu shape
float GetIoU(Box a, Box b)
{
    float Intersection;
    float Union;
    //交集
    float x1 = Math.Max(a.x1, b.x1);
    float y1 = Math.Max(a.y1, b.y1);
    float x2 = Math.Min(a.x2, b.x2);
    float y2 = Math.Min(a.y2, b.y2);

    float w = x2 - x1;
    float h = y2 - y1;
    Intersection = w * h;
        
    //聯集
    Union = (a.x2 - a.x1) * (a.y2 - a.y1) +
        (b.x2 - b.x1) * (b.y2 - b.y1) - Intersection;

    float calcIoU = Intersection / Union;
    return calcIoU;
}

Console.Write("請輸入IoU閾值(0, 1]，例如 0.5 或 0.8（輸入無效值將使用預設值0.5）：");
if (!float.TryParse(Console.ReadLine(), out IoU))
{
    Console.WriteLine("使用預設值0.50");
    IoU = 0.5f;
} 
else if (IoU > 1 || IoU <= 0)
{
    Console.WriteLine("使用預設值0.50");
    IoU = 0.5f;
}
Console.WriteLine($"IoU閾值：{IoU:F2}");

List<Box> boxes = new List<Box>();

try
{
    using (StreamReader sr = new StreamReader("../../../boxes.txt"))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            List<float> l = line.Split(" ").Select(x => float.Parse(x)).ToList();
            boxes.Add(new Box(l[0], l[1], l[2], l[3], l[4], l[5]));
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}

List<Box> ans = new List<Box>();
List<List<Box>> clusters = new List<List<Box>>();

foreach (var box in boxes)
{
    bool match = false;
    foreach (var cluster in clusters)
    {
        if (GetIoU(box, cluster[0]) > IoU)
        {
            cluster.Add(box);
            match = true;
            break;
        }
    }
    if (!match)
    {
        clusters.Add(new List<Box> { box });
    }
}

foreach (var i in clusters)
{
    ans.Add(Fusion(i));
}

Console.WriteLine($"融合後的框數量：{ans.Count}");
for (int i = 0; i < ans.Count; i++)
{
    Console.WriteLine($"框{i+1}：{ans[i]}");
}

using (StreamWriter sw = new StreamWriter("../../../fused_boxes.txt"))
{
    sw.WriteLine($"""
                 IoU Threshold: {IoU:F2}
                 Number of Fused Boxes: {ans.Count}
                 x1 y1 x2 y2 score weight
                 """);
    foreach (var i in ans)
    {
        sw.WriteLine($"{i.x1:F2} {i.y1:F2} {i.x2:F2} {i.y2:F2} {i.score:F2} {i.weight:F2} ");
    }
}

//0.82232344 (0,1)
//0.6806723 (0,2)
//0.82232344 (1,2)
//>=0.8 -> (0,1) (2)

class Box
{
    public Box(float _x1, float _y1, float _x2, float _y2, float _score, float _weight)
    {
        x1 = _x1;
        x2 = _x2;
        y1 = _y1;
        y2 = _y2;
        score = _score;
        weight = _weight;
    }
    public float x1 { get; set; }
    public float y1 { get; set; }
    public float x2 { get; set; }
    public float y2 { get; set; }
    public float score { get; set; }
    public float weight { get; set; }
    public override string ToString()
    {
        return $"x1={x1:F2}，y1={y1:F2}，x2={x2:F2}，y2={y2:F2}，score={score:F2}，weight={weight:F2}";
    }
}
