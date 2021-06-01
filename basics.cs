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
i = Int32.Parse(s);
//public static void log()
Console.WriteLine(~(0b01010101 | 0b1010 & 0b10000 ^ 0b111)>>2);
int a,b,c;
a=b=c=2*8;
a+=2; b-=2; //...
b = (int)(a*2):
b = (a==b) && (b<=a)
if (a>c && (c % 2) == 0) {...}
for while do break continue

int i = 8;
int[] ints;
ints = new int[i];
ints = new int[]{1,2,2};
foreach (var el in ints) {
    Console.WriteLine(el);
}
int [,] ints2d = {{1,2,42}, {4,5,3}};
Console.WriteLine($"max index: {ints2d.GetUpperBound(0)}, len:{ints2d.Length}");
// ints2d[0] - not work like slice
//NB [,] - 2d array but [][] is array of array
int [][] numsaa = new int[2][];
numsaa[0] = new int[] {2,3};
numsaa[1] = new int[] {3};
Console.WriteLine($"max index: {numsaa.GetUpperBound(0)}, len:{numsaa.Length}");
Console.WriteLine($"len:{numsaa[0].Length}");
// Length - is all elements

static int oddMultiply(int a, int b) {
    int c = a * b * 3;
    if (c % 2 == 0) return c+1;
    return c;
}
static void log(string s) => Console.WriteLine(s);
log(oddMultiply(2,3).ToString());

static void fa(char c, int a=8) {}
fa(a:2,c:'a');

static void addx(ref int a) { a+= 3;}
addx(ref y);
// out - must set
static void addo(out int a) { a+= 3;}
addo(out y);
// in - not change
static void addi(in int a) { a+= 3;}
addi(in y);

static int manyint(params int[] ys) { return 0; }

enum Daypart : byte {
    Morning, Afternoon, Evening, Night
}
Daypart m = daypart.Morning;

var t = (2,3);
(int x, int y) t2;
var t3 = (name:"a", fio:"b");
Console.WriteLine(t.Item2);
t3.fio+="axxxxx";
Console.WriteLine(t3.fio);
