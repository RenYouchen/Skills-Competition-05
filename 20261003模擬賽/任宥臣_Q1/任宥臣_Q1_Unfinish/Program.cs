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

List<Work> works = new List<Work>();
for (int i = 0; i < n; i++)
{
    var data = Console.ReadLine().Split();
    works.Add(new Work(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3])));
}
works.Sort((a,b) => a.T.CompareTo(b.T));
var sortByTime = works.GroupBy(x => x.T).ToList();
PriorityQueue<string, int> pq = new PriorityQueue<string, int>();
List<Work> done = new List<Work>();
int timer = 0;
Work currentWork = null;
while (done.Count != works.Count)
{
    foreach (var work in works)
    {
        if(currentWork == null)
        {
            if (!done.Contains(work) && work.T == timer)
            {
                pq.Enqueue(work.I, work.T);
            }
        }
    }

    currentWork = works.Find(x=>x.I == pq.Dequeue());
    

    if(currentWork != null && currentWork.T + currentWork.D > timer)
    {
        done.Add(currentWork);
        currentWork = null;
    }

    timer++;

}
record Work(string I, int T, int D, int P);