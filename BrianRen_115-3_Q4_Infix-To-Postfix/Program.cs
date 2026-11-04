// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

while (true)
{
    Console.WriteLine("輸入");
    string raw = Console.ReadLine();
    var data = Regex.Matches(raw, @"\d+|[+\-*/()]").Select(x=>x.Value).ToList();

    var output = new List<string>();
    var opStack = new Stack<string>();
    foreach (var oper in data)
    {
        switch (oper)
        {
            case "(":
                opStack.Push(oper);
                break;
            case ")":
                while(opStack.Peek()!="(")
                    output.Add(opStack.Pop());
                opStack.Pop();
                break;
            case "+" or "-" or "*" or "/":
                while (opStack.Count > 0 && opStack.Peek() != "(" && Precedence(opStack.Peek()) >= Precedence(oper)) 
                    output.Add(opStack.Pop());
                opStack.Push(oper);
                break;
            default:
                output.Add(oper); //num
                break;
        }
    }

    while (opStack.Count > 0)
        output.Add(opStack.Pop());
    Console.WriteLine("輸出");
    Console.WriteLine(string.Join(" ", output));

    var numStack = new Stack<int>();
    foreach (var token in output)
    {
        if (int.TryParse(token, out int num))
        {
            numStack.Push(num);
            continue;
        }

        int rop = numStack.Pop();
        int lop = numStack.Pop();
        
        numStack.Push(token switch
        {
            "+" => lop + rop,
            "-" => lop - rop,
            "*" => lop * rop,
            "/" => lop / rop,
            _=>0
        });
    }
    Console.WriteLine(numStack.Peek());
}

int Precedence(string op) => op switch
{
    "+" or "-" => 1,
    "*" or "/" => 2,
    _ => 0
};