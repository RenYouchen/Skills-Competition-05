Console.WriteLine("Hello, World!");

record Elevator(ElevatorState State, int CurrentFloor);

enum ElevatorState
{
    Up,
    Down,
    Stop
}
