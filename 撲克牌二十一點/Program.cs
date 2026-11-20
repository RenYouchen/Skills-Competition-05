// See https://aka.ms/new-console-template for more information
/*
3
2 10 5
3 K Q 2 5 9 3 10 
   
   
3
2 4 3
10 5 10 8 9 9 A 5
S
5
8
S
9
 */

int N = int.Parse(Console.ReadLine()!);
var P = Console.ReadLine()!.Split().Select(int.Parse).ToList();

var players = new Player[N + 1];
for (int i = 0; i < players.Length; i++) players[i] = new Player();
players[0].isBanker = true;

var c = Console.ReadLine()!.Split();

for (int i = 0; i <= N; i++)
{
    for (int j = 0; j < 2; j++)
    {
        players[i].cards.Add(c[i * 2 + j]);
    }
}

bool end = false;
for (int i = 0; i <= N; i++)
{
    if (i == 0 && players[0].points == 21)
    {
        end = true;
        i++;
    }

    if (end)
    {
        players[i].money -= P[i-1];
        players[0].money += P[i-1];
    }
}

for (int i = 1; i <= N && !end; i++)
{
    string s; 
    while ((s = Console.ReadLine())!="S" && players[i].isExplode == false) 
    {
        players[i].cards.Add(s);
        if (players[i].isExplode)
        {
            players[0].money += P[i - 1];
            players[i].money -= P[i - 1];
            break;
        }
        if (players[i].points == 21)
        {
            players[i].money += P[i - 1];
            players[0].money -= P[i - 1];
            break;
        }
    }
}

while (players[0].points < 17)
{
    players[0].cards.Add(Console.ReadLine());
}

if (players[0].points > 21)
{
    for (int i = 1; i <= N; i++)
    {
        if (players[i].points < 21)
        {
            players[i].money += P[i - 1];
            players[0].money -= P[i - 1];
        }
    }
}
else
{
    for (int i = 1; i <= N; i++)
    {
        if (players[i].points <= players[0].points)
        {
            players[i].money -= P[i - 1];
            players[0].money += P[i - 1];
        }
        else
        {
            players[i].money += P[i - 1];
            players[0].money -= P[i - 1];
        }
    }
}

for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"Player{i} {players[i].money}");
}
Console.WriteLine($"Player{0} {players[0].money}");

class Player
{
    
    static List<string> symbol = "A 2 3 4 5 6 7 8 9 10 J Q K".Split(' ').ToList();
    static List<int> point = "11 2 3 4 5 6 7 8 9 10 10 10 10".Split(' ').Select(int.Parse).ToList();

    public int money = 10;
    public List<string> cards = [];

    public bool isBanker = false;

    public bool isExplode => points > 21;
    public int hasA => cards.Count(x=>x=="A");

    public int points
    {
        get
        {
            // => ;
            int sum = cards.Select(x => point[symbol.IndexOf(x)]).Sum();
            int count = 0;
            while (sum > 21 && hasA > count)
            {
                sum -= 10;
                count++;
            }

            return sum;
        }
    }
}