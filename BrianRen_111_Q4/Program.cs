List<int> storage = new List<int>();

bool AddLeft()
{
    if (storage.Count >= 5) return false;
    // storage.Insert(0, data);
    return true;
}

bool DelLeft()
{
    return true;
}

bool AddRight()
{
    if (storage.Count >= 5) return false;
    // storage.Insert(storage.Count, data);
    return true;
}

bool DelRight()
{
    return true;
}
while (true)
{
    Console.WriteLine("""
                      南港公司生產排程系統
                      請選擇：
                      1.從生產線左邊加入物品
                      2.從生產線左邊刪除物品
                      3.從生產線右邊加入物品
                      4.從生產線右邊刪除物品
                      5.生產排程結束
                      """);
    Console.Write("? ");
    
    int todo;
    int.TryParse(Console.ReadLine(), out todo);
    
    switch (todo)
    {
        case 1:
            AddLeft();
            return;
        case 2:
            DelLeft();
            return;
        case 3:
            AddRight();
            return;
        case 4:
            DelRight();
            return;
        case 5:
            Console.WriteLine("生產排程系統結束!");
            break;
        default: 
            Console.WriteLine("輸入錯誤！請重新輸入！");
            return;
    }
}