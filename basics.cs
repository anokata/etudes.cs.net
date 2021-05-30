// vim: set ft=cs:
string name = "soenaught'z";
bool b = true || false;
int i = 1 + 0b1010101 * -2 * 0xA0;
double d = 0.2 + 3.1415e8 * 1.01e-2;
char c = '\n'; c = '\x5A';
//x = null;
//byte, sbyte, short, ushort, int, uint, long, ulong, float, double, decimal, char, string, object
decimal d = 1005.3M;
uint ui = 123U; // L UL

Console.WriteLine(true && false);
Console.WriteLine(i);
Console.WriteLine(c);

var some = 100 * 23;
Console.WriteLine(some.GetType().ToString());

Console.WriteLine("{0} is {1}", b, i);
string s = Console.ReadLine();
i = Convert.ToInt32(s);
i = Convert.ToInt32(Console.ReadLine());
//public static void log()
Console.WriteLine(~(0b01010101 | 0b1010 & 0b10000 ^ 0b111)>>2);
int a,b,c;
a=b=c=2*8;
a+=2; b-=2; //...
b = (int)(a*2):
b = (a==b) && (b<=a)
if (a>c && (c % 2) == 0) {...}

