// See https://aka.ms/new-console-template for more information
/*
add 10
add 20
add 30
display
search 20
remove 20
display
search 20
exit
 */
List<string> list = new List<string>();
bool stop = false;
while (!stop)
{
    var raw = Console.ReadLine().Split();
    var parm = raw[1..].ToList();

    switch (raw[0])
    {
        case "add":
            list.Add(parm[0]);
            Console.WriteLine("Added: "+ parm[0]);
            break;
        case "remove":
            var isRemoved = list.Remove(parm[0]);
            Console.WriteLine(isRemoved?"Removed: " + parm[0]:"Not Found");
            break;
        case "search":
            var d = list.IndexOf(parm[0]);
            Console.WriteLine(d == -1? "Not Found" : $"Position of {parm[0]}: {d}");
            break;
        case "display":
            Console.WriteLine(string.Join(" -> ", list));
            break;
        case "exit":
            stop = true;
            break;
        default:
            break;
    }
}
Console.ReadKey();