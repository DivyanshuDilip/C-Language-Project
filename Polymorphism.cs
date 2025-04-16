using System;
namespace Project
{
    class Polymorphism
    {
        int a;
        int b;
        public void add()
        {
            a = 10;
            b = 20;
            Console.WriteLine(a + b);
        }

        public int add(int a, int b)
        {
            return a + b;

        }
        public static void Main(string[] args)
        {
            Polymorphism poly = new Polymorphism();
            poly.add();
            Console.WriteLine(poly.add(50, 50));

        }
    }
}
