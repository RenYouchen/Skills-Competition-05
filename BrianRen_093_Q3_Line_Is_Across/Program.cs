// See https://aka.ms/new-console-template for more information
/*
2 4
1 1
3 3
4 1

2 4
1 1
1 3
4 1

2 4
2 1
2 2
4 2
 */
List<List<int>> lst = new List<List<int>>();
Console.Write("A(X1,Y1)=");
lst.Add(Console.ReadLine()!.Split().Select(int.Parse).ToList());
Console.Write("B(X2,Y2)=");
lst.Add(Console.ReadLine()!.Split().Select(int.Parse).ToList());
Console.Write("C(X3,Y3)=");
lst.Add(Console.ReadLine()!.Split().Select(int.Parse).ToList());
Console.Write("D(X4,Y4)=");
lst.Add(Console.ReadLine()!.Split().Select(int.Parse).ToList());

int line(List<int> p1,  List<int> p2, List<int> p) =>
    p[0] * (p1[1] - p2[1]) - p[1] * (p1[0] - p2[0]) + p1[0] * p2[1] - p2[0] * p1[1];

//Console.WriteLine(line(lst[0], lst[1], lst[0]));

int p3VsL1 = line(lst[0], lst[1], lst[2]);
int p4VsL1 = line(lst[0], lst[1], lst[3]);

int p1VsL2 = line(lst[2], lst[3], lst[0]);
int p2VsL2 = line(lst[2], lst[3], lst[1]);

if(p3VsL1 * p4VsL1 <= 0 && p1VsL2 * p2VsL2 <= 0)
{
    Console.WriteLine("綫有交叉.");
} else
{
    Console.WriteLine("綫無交叉.");
}