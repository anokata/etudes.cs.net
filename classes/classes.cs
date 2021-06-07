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
}
