using System;
using log = System.Console;
using static System.Console;

namespace LearnClasses {

    class Prog {
        public static void Main(string[] args) {
            Console.WriteLine("...!");
            Figurine f1 = new Figurine();
            f1.logInfo();
            Figurine f2 = new ("Zelda");
            f2.logInfo();
            Figurine f3 = new Figurine {name="Got it!"};
            f3.logInfo();
            Human h = new("zzz");
            log.WriteLine(h);
            log.WriteLine(h.getMark());
            log.WriteLine(h.getMark('d'));

            Vector2d v1 = new Vector2d { x = 1, y = 2 };
            Vector2d v2 = new Vector2d { x = 2, y = 4 };
            log.WriteLine((v1 + v2).mag());

            log.WriteLine("======");
            log.WriteLine("abc"[0]);
            log.WriteLine((int)("abc"[0]));
            log.WriteLine((int)("abc"[0]) - 'a');
        }
    }

    class Figurine {
        public string name = "default_name";

        public void logInfo() {
            Console.WriteLine($"Figurine: {name}");
        }

        public Figurine () {
            name = "[magic]";
        }

        public Figurine(string name) : this() {
            this.name = name;
        }
    }

    struct Human {
        string role;
        const byte NumberOfLegs = 2; // is static 
        public readonly uint Height;

        public Human(string role) {
            this.role = role;
            this.Height = (uint)(role.Length * 2);
        }
        
        static Human() {
            log.WriteLine("[Human static init]");
        }

        public int getMark() {
            return role.Length;
        }

        public string getMark(char c) {
            return role.Substring(2) + c;
        }

        public static int getMark(int x) {
            return x*2;
        }
    }

    class Vector2d {
        public int x {get; set;}
        public int y {get; set;}
        public int mag() {
            return (int)(Math.Round(Math.Sqrt(x*x+y*y)));
        }
        public static Vector2d operator +(Vector2d a, Vector2d b) {
            log.WriteLine("Vector2d operator +");
            return new Vector2d {x = a.x + b.x, y = a.y + b.y };
        }
    }
}
