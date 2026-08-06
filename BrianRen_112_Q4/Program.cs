int n;
int[,] board;
using (StreamReader sr = new StreamReader("../../../input.txt"))
{
    n = int.Parse(sr.ReadLine());

    var a = sr.ReadLine().Split(' ').Select(int.Parse).ToList();
    board = new int[a[0], a[1]];

    string line;
    while (n-- > 0)
    {
        var xy = sr.ReadLine().Split(' ').ToList();
        var drone = new Drone(int.Parse(xy[0]), int.Parse(xy[1]), Enum.Parse<Drone.Direction>(xy[2]), false, board);
        var cmd = sr.ReadLine();
        foreach (var i in cmd)
        {
            drone = i switch
            {
                'L' => drone.RtLeft(),
                'R' => drone.RtRight(),
                'F' => drone.Move()
            };
            if (drone.IsDestroy)
            {
                Console.WriteLine($"{drone.X} {drone.Y} {drone.Facing.ToString()} Destroyed");
                break;
            }
        }

        if (!drone.IsDestroy) Console.WriteLine($"{drone.X} {drone.Y} {drone.Facing.ToString()}");
    }
}

record Drone(int X, int Y, Drone.Direction Facing, bool IsDestroy, int[,] Board)
{
    public enum Direction
    {
        N,
        E,
        S,
        W
    };

    public Drone RtLeft()
    {
        int newFacing = ((int)Facing - 1) % 4;
        if (newFacing < 0) newFacing += 4;
        return this with { Facing = (Direction)newFacing };
    }

    public Drone RtRight()
    {
        int newFacing = ((int)Facing + 1) % 4;
        if (newFacing < 0) newFacing += 4;
        return this with { Facing = (Direction)newFacing };
    }

    public Drone Move()
    {
        (int, int) movement = Facing switch
        {
            Direction.N => (0, 1),
            Direction.S => (0, -1),
            Direction.W => (-1, 0),
            Direction.E => (1, 0)
        };
        if (CheckIfDestroy(this with { X = X + movement.Item1, Y = Y + movement.Item2 }))
        {
            return this with { IsDestroy = true };
        }
        else
        {
            return this with { X = X + movement.Item1, Y = Y + movement.Item2 };
        }
    }

    public bool CheckIfDestroy(Drone d) => (d.X > Board.GetLength(0) || d.X < 0 || d.Y > Board.GetLength(1) || d.Y < 0);
};