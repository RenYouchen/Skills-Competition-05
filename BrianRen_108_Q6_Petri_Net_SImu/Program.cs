// See https://aka.ms/new-console-template for more information
//「」

/*
4 a b c d
4 e f g h
1 i
t2 b c f
1
t3 e f g 
1
t4 d f h
1
t5 g h i
0
t1 a e
0
 */

using System.Xml.Schema;

List<string> input;
Console.WriteLine("鍵入「輸入小圓盤」的數目及其名稱：");
input = Console.ReadLine().Split(' ').ToList();
var nInput = int.Parse(input[0]);
var inputNode = input[1..];

Console.WriteLine("鍵入「內部小圓盤」的數目及其名稱：");
input = Console.ReadLine().Split(' ').ToList();
var nInternal = int.Parse(input[0]);
var internalNode = input[1..];

Console.WriteLine("鍵入「輸出小圓盤」的數目及其名稱：");
input = Console.ReadLine().Split(' ').ToList();
var nOutput = int.Parse(input[0]);
var outputNode = input[1..];

Console.WriteLine("鍵入「2-1轉移棒」的名稱及小圓盤的名稱：");
List<TransStick> tsList = new List<TransStick>();
while (true)
{
    var data = Console.ReadLine().Split();
    tsList.Add(new()
    {
        id = data[0],
        inputs = data[1..3].ToList(),
        outputs = { data[3] }
    });
    Console.Write("Continue?(1/0):");
    if(Console.ReadLine() == "0") break;
}

Console.WriteLine("鍵入「1-1轉移棒」的名稱及小圓盤的名稱：");
while (true)
{
    var data = Console.ReadLine().Split();
    tsList.Add(new()
    {
        id = data[0],
        inputs = { data[1] },
        outputs = { data[2] }
    });
    Console.Write("Continue?(1/0):");
    if(Console.ReadLine() == "0") break;
}

Console.Write("轉移棒與小圓盤的關係：");
foreach (var transStick in tsList)
{
    Console.Write($"{transStick.id}: {string.Join(' ', transStick.inputs)} {transStick.outputs[0]} ");
}
Console.WriteLine();
Console.WriteLine("小圓盤與轉移棒的關係：");
var allNodes = inputNode.Concat(internalNode).Concat(outputNode);
var token = new Dictionary<string, bool>();

foreach (var node in allNodes)
{
    token[node] = false;
    var ts = tsList.Where(x => x.inputs.Concat(x.outputs).Contains(node)).OrderBy(x=>x.id);
    Console.Write($"{node}: {string.Join(' ', ts.Select(x=>x.id))} ");
}
Console.WriteLine();

while (true)
{
    Console.Write("鍵入將放權杖的小圓盤名稱:");
    var node = Console.ReadLine();

    token[node] = true;
    Console.Write("查看各個小圓盤權杖的情況: ");
    Console.WriteLine(string.Join(' ', token.Select(x=>$"{x.Key}:{(x.Value?1:0)}")));
    
    Console.WriteLine("執行轉移棒");

    var ts = tsList.Where(x => x.inputs.Contains(node)).ToList();
    var queue = new Queue<TransStick>();
    foreach (var transStick in ts)
    {
        queue.Enqueue(transStick);
    }
    
    while (queue.Count > 0)
    {
        var transStick = queue.Peek();
        if (transStick.inputs.All(p => token[p]))
        {
            Fire(transStick);
            foreach (var transStickOutput in transStick.outputs)
            {
                foreach (var i in tsList.Where(x=>x.inputs.Contains(transStickOutput)))
                {
                    queue.Enqueue(i);
                }
            }
        }
        queue.Dequeue();
    }
    Console.Write("查看各個小圓盤權杖的情況: ");
    Console.WriteLine(string.Join(' ', token.Select(x=>$"{x.Key}:{(x.Value?1:0)}")));
    Console.Write("Continue?(1/0):");
    if(Console.ReadLine() == "0") break;
}

void Fire(TransStick s)
{
    foreach (var input in s.inputs)
    {
        token[input] = false;
    }

    foreach (var output in s.outputs)
    {
        token[output] = true;
    }
}

class TransStick
{
    public string id;
    public List<string> inputs = new();
    public List<string> outputs = new();
}