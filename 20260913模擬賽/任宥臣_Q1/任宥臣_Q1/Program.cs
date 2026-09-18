while(true)
{
    string s;
    Console.Write("輸入密碼：");
    s = Console.ReadLine();
    if (s == "") break;
    bool hasLower = false;
    bool hasUpper = false;
    bool hasDigital = false;
    for(int i = 0; i < s.Count(); i++)
    {
        if (char.IsDigit(s[i])) hasDigital = true;
        if (char.IsLower(s[i])) hasLower = true;
        if (char.IsUpper(s[i])) hasUpper = true;
    }

    int count = 0;
    char prev = s[0];
    bool repeat = false;
    for (int i = 1; i < s.Count(); i++) {
        if (prev == s[i])
        {
            count++;
        } else
        {
            count = 0;
        }
        if (count > 1) repeat = true;
        prev = s[i];
    }
    string ans = (!repeat && hasDigital && hasLower && hasUpper && s.Count() >= 12) ? "強" : "弱";
    Console.WriteLine($"輸出結果：小寫字母數={s.Where(x => char.IsLower(x)).Count()}，" +
        $"大寫字母數={s.Where(x=>char.IsUpper(x)).Count()}，" +
        $"數字數={s.Where(x=>char.IsDigit(x)).Count()}，" +
        $"判定結果：{ans}密碼");
    //if(!repeat && hasDigital && hasLower && hasUpper && s.Count() > 12 || true)
    //{
    //    Console.WriteLine(repeat);
    //}
}

Console.ReadKey();