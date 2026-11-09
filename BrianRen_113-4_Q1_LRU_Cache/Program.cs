// See https://aka.ms/new-console-template for more information
/*
2
put 1 10
put 2 20
all
get 1
put 3 30
all
get 2
exit
 */
int n = int.Parse(Console.ReadLine());
List<Data> datas = new List<Data>();
bool stop = false;
int count = 0;

while (!stop)
{
    var cmd = Console.ReadLine().Split();
    var parm = cmd[1..].Select(int.Parse).ToList();
    switch (cmd[0])
    {
        case "put":
            if (datas.Find(x => x.id == parm[0]) != null)
            {
                datas[datas.IndexOf(datas.Find(x => x.id == parm[0]))] =
                    datas.Find(x => x.id == parm[0]) with { data = parm[1], count = count++};
            }
            datas.Add(new Data(parm[0], parm[1], count++));
            Console.WriteLine($"PUT: {parm[0]} -> {parm[1]}");
            if (datas.Count > n)
            {
                datas.Remove(datas.MinBy(x => x.count));
            }
            break;
        case "get":
            var d = datas.Find(x => x.id == parm[0]);
            if (d == null)
            {
                Console.WriteLine("GET: Not Found");
                break;
            }
            else Console.WriteLine($"GET: {d.id} -> {d.data}");
            datas[datas.IndexOf(d)] = d with { count = count++ };
            break;
        case "all":
            Console.WriteLine(string.Join("\n", datas));
            break;
        case "exit":
            stop = true;
            break;
        default:
            break;
    }
}
Console.ReadKey();

record Data(int id, int data, int count)
{
    public override string ToString()
    {
        return $"KEY: {id}, VALUE: {data}";
    }
};

