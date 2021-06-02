using System;

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
            Human h;
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

        public Human(string role) {
            this.role = role;
        }
    }
}
