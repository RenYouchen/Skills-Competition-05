/*
6 2 3
P1 0 4 5
P2 4 3 3
P3 4 2 5
P4 6 2 5
P5 8 1 4
P6 4 1 1
 */


var nab = Console.ReadLine().Split().Select(int.Parse).ToList();

int n = nab[0];
int a = nab[1];
int b = nab[2];

int time = 0;
List<Work> jobs = new List<Work>();
List<string> order = new List<string>();
for (int i = 0; i < n; i++)
{
    var data = Console.ReadLine().Split();
    jobs.Add(new Work(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3])));
}
List<Work> pending = new List<Work>(jobs);

while (pending.Count > 0)
{
    var ready = pending.Where(x => x.T <= time).ToList();
    if (ready.Count == 0)
    {
        time = pending.Min(x => x.T);
        continue;
    }

    var next = ready.Where((x => x.bypass >= b)).FirstOrDefault();
    if (next != null)
        next.forced = true;
    else
        next = ready
            .OrderByDescending(x => x.P + (time - x.T) / a)
            .First();

    foreach (var work in ready)
    {
        if (work != next) work.bypass++;
    }

    next.start = time;
    next.finish = time + next.D;
    time = next.finish;
    order.Add(next.I);
    pending.Remove(next);
}

Console.WriteLine(string.Join(" ", order));

Console.WriteLine("ID START FINISH WAIT TURNAROUND BYPASS FORCED");
foreach (var w in jobs)
{
    Console.WriteLine($"{w.I} {w.start} {w.finish} {w.wait} {w.turnaround} {w.bypass} {(w.forced==false? 0:1)}");
}

record Work(string I, int T, int D, int P) 
{
    public int start { get; set; }
    public int finish { get; set; }
    public int bypass { get; set; }
    public bool forced {get; set;}

    public int wait => start - T;
    public int turnaround => finish - T;
}