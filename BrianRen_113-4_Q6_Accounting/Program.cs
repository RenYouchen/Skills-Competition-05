// See https://aka.ms/new-console-template for more information
/*
add 2024-11-15 500 Salary
add 2024-11-16 -100 Grocery
add 2024-11-16 -50 Transport
display
query 2024-11-16
delete 2
display
balance
exit
 */
bool stop = false;
int count = 0;
List<Data> datas = new List<Data>();
while (!stop)
{
    var cmd = Console.ReadLine().Split();
    switch (cmd[0])
    {
        case "add":
            Console.WriteLine($"Added: {cmd[2]} on {cmd[1]} - {cmd[3]} (ID: {++count})");
            datas.Add(new Data(cmd[1], cmd[2], cmd[3], count));
            break;
        case "query":
            var d = datas.Where(x => x.dt == cmd[1]);
            if (d == null)
            {
                Console.WriteLine($"No records on {cmd[1]}");
            }

            foreach (var z in d)
            {
                Console.WriteLine($"{z.count}. {z.amount} - {z.remark}");
            }

            break;
        case "display":
            if (datas.Count == 0)
            {
                Console.WriteLine("No records");
                break;
            }
            Console.WriteLine(string.Join("\n", datas));
            break;
        case "delete":
            var e = datas.FindIndex(0, x => x.count == int.Parse(cmd[1]));
            Console.WriteLine(e == -1 ? $"Record {cmd[1]} not found": $"Delete record: {cmd[1]}");
            if(e!=-1) datas.RemoveAt(e);
            break;
        case "balance":
            var g = datas.GroupBy(x => int.Parse(x.amount) >= 0).ToList();
            Console.WriteLine($"Total Income: {g.First().Sum(x=>int.Parse(x.amount))}, " +
                              $"Total Expense: {g.Last().Sum(x=>int.Parse(x.amount))}, " +
                              $"Balance: {datas.Sum(x=>int.Parse(x.amount))}");
            break;
        case "exit":
            stop = true;
            break;
    }
}

Console.ReadKey();

record Data(string dt, string amount, string remark, int count)
{
    public override string ToString()
    {
        return $"{count}. {dt} {amount} - {remark}";
    }
};