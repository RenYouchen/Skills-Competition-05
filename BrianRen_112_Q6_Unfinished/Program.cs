var file1 = File.ReadLines("_f1.txt");


record Elevator(ElevatorState State, int CurrentFloor);

enum ElevatorState
{
    Up,
    Down,
    Stop
}
