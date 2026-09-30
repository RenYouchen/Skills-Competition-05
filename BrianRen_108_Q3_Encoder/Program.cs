// See https://aka.ms/new-console-template for more information

string M = Console.ReadLine();

int h0 = 0xabcd;
int h1 = 0xcdef;
int h2 = 0x2266;
int h3 = 0xceed;
int h4 = 0xaccd;

int a = h0;
int b = h1;
int c = h2;
int d = h3;
int e = h4;
char[] word = "     ".ToCharArray(); 
for (int i = 0; i <= 4; i++)
{
    word[i] = (char)(M[i] - ' ');
    int f = b + c;
    int k = 0x5a82;
    int temp = 4 * a + f + e + k + word[i];
    e = d;
    d = c;
    c = b;
    b = a;
    a = temp;
}
h0 = h0 + a;
h1 = h1 + b;
h2 = h2 + c;
h3 = h3 + d;
h4 = h4 + e;

Console.WriteLine($"{h0:x8} {h1:x8} {h2:x8} {h3:x8} {h4:x8}");