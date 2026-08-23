var storage = new List<int?>{null, null, null, null, null};
int input;
var leftPointer = 4;
var rightPointer = 0;

// int GetIndex(int pointer, int pos)
// {
//     int count = storage.Count(x => x != null);
//     if (pointer + pos < 0) return pointer + count;
//     if (pointer + pos > count) return 0;
//     return pointer + pos;
// }

// int GetIndex(int pointer, int pos)
// {
//     int count = storage.Count(x => x != null);
//     if (count == 0) return 0;
//     int target = pointer + pos;
//     if (target < 0) return count - 1;
//     if (target >= count) return 0;
//     return target;
// }

void Full()
{
    Console.WriteLine($"生產線滿了！\n生產線上有 {storage.Count(x=>x!=null)} 物件");
}


void Empty() => Console.WriteLine($"生產線空的！\n生產線上有 {storage.Count(x=>x!=null)} 物件");
bool AddLeft()
{
    if (storage.Count(x=> x!=null) >= 5) return false;
    leftPointer++;
    leftPointer %= 5;
    storage[leftPointer] = input;
    Console.WriteLine($"左邊作業員編號：{leftPointer}");
    Console.WriteLine($"右邊作業員編號：{rightPointer}");
    // storage.Insert(leftPointer, input);
    Console.WriteLine($"加入物件: {input}");
    Console.WriteLine($"流水線線上有 {storage.Count(x=>x!=null)} 物件");
    return true;
}

bool DelLeft()
{
    if (storage.Count(x=> x!=null) == 0) return false;
    int? rmItem = storage[leftPointer];
    storage[leftPointer] = null;
    leftPointer--;
    if (leftPointer == -1) leftPointer = 4;
    Console.WriteLine("從左邊刪除: ");
    Console.WriteLine($"左邊作業員編號：{leftPointer}");
    Console.WriteLine($"右邊作業員編號：{rightPointer}");
    Console.WriteLine($"\n刪除物件編號: {rmItem}");
    return true;
}

bool AddRight()
{
    if (storage.Count(x=> x!=null) >= 5) return false;
    rightPointer--;
    if (rightPointer == -1) rightPointer = 4;
    storage[rightPointer] = input;
    Console.WriteLine($"左邊作業員編號：{leftPointer}");
    Console.WriteLine($"右邊作業員編號：{rightPointer}");
    // storage.Insert(leftPointer, input);
    Console.WriteLine($"加入物件: {input}");
    Console.WriteLine($"流水線線上有 {storage.Count(x=>x!=null)} 物件");
    return true;
}

bool DelRight()
{
    if (storage.Count(x=> x!=null) == 0) return false;
    int? rmItem = storage[rightPointer];
    storage[rightPointer] = null;
    
    rightPointer++;
    rightPointer%=5;
    Console.WriteLine("從右邊刪除: ");
    Console.WriteLine($"左邊作業員編號：{leftPointer}");
    Console.WriteLine($"右邊作業員編號：{rightPointer}");
    Console.WriteLine($"\n刪除物件編號: {rmItem}");
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

    bool status;
    switch (todo)
    {
        case 1:
            Console.Write("請輸入物件編號: ");
            input = int.Parse(Console.ReadLine());
            status = AddLeft();
            if(!status) Full();
            break;
        case 2:
            status = DelLeft();
            if(!status) Empty();
            break;
        case 3:
            Console.Write("請輸入物件編號: ");
            input = int.Parse(Console.ReadLine());
            status = AddRight();
            if(!status) Full();
            break;
        case 4:
            status = DelRight();
            if(!status) Empty();
            break;
        case 5:
            Console.WriteLine("生產排程系統結束!");
            return;
        default:
            Console.WriteLine("輸入錯誤！請重新輸入！");
            break;
    }
}