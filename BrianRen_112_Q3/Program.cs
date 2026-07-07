int[,] board = new int[3,3];

void PrintBoard()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(board[i,j] == 0?"口":board[i,j]==1?"Ｏ":"Ｘ");
        }
        Console.WriteLine();
    }
}

int CheckWin()
{
    int winPlayer = 0;

    for (int i = 0; i < 3; i++)
    {
        if ((board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0,i] != 0))
        {
            winPlayer = board[0, i];
        }

        if ((board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0))
        {
            winPlayer = board[i, 0];
        }

        if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0))
        {
            winPlayer = board[0, 0];
        }
        
        if ((board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[2, 0] != 0))
        {
            winPlayer = board[2, 0];
        }
    }
    
    return winPlayer;
}

int count = 0;
while (true)
{
    Console.WriteLine("你為Ｏ、電腦為Ｘ\n位置對應數字鍵盤\n");
    PrintBoard();
    Console.Write("請輸入1～9(按0鍵結束)：");
    
    int a = int.Parse(Console.ReadLine());
    if (a==0) break;
    if (board[2 - (a - 1) / 3, (a - 1) % 3] > 0)
    {
        Console.WriteLine("已經有棋子了");
        continue;
    }
    board[2 - (a - 1) / 3, (a - 1) % 3] = 1;
    count++;
    
    if (CheckWin() > 0)
    {
        PrintBoard();
        Console.WriteLine((CheckWin() == 1 ? "你○方獲勝" : "電腦Ｘ方獲勝") + " 再來一盤");
        board = new int[3,3];
        count = 0;
        continue;
    }
    if (count == 9)
    {
        PrintBoard();
        Console.WriteLine("雙方平手 再來一盤");
        board = new int[3,3];
        count = 0;
        continue;
    }
    int b = Random.Shared.Next(1,10);
    while (board[2 - (b - 1) / 3, (b - 1) % 3] > 0)
        b = Random.Shared.Next(1,10);
    board[2 - (b - 1) / 3, (b - 1) % 3] = 2;
    count++;
    if (CheckWin() > 0)
    {
        PrintBoard();
        Console.WriteLine((CheckWin() == 1 ? "你○方獲勝" : "電腦Ｘ方獲勝") + " 再來一盤");
        board = new int[3,3];
        count = 0;
        continue;
    }

    PrintBoard();
}
