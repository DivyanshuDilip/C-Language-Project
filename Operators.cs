namespace CSharpPrograms
{
    class Operators
    {
        public static void Main(string[] args)
        {
            // Arithematic Operator [+,-,/,%]
            int a = 50;
            int b = 100;
            Console.WriteLine("Arithematic Operator");
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            // Relational Operators [<,>,<=,>=]
            Console.WriteLine("Relational Operators");
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);

            // Logical Operators [!,&&,||]
            Console.WriteLine("Logical Operators");
            Console.WriteLine(a < b && a > b);
            Console.WriteLine(a < b || a > b);
            Console.WriteLine(!(a < b));

            // Terinary Operator [? :]
            Console.WriteLine("Terinary Operator");
            Console.WriteLine(a < b ? a : b);

            // Equality Operator [== , !=]
            Console.WriteLine("Equality Operator");
            Console.WriteLine(a < b == a > b);
            Console.WriteLine(a < b != a > b);
            // Increment/ Decrement Operator [++, --]
            Console.WriteLine("Increment/ Decrement Operator");
            Console.WriteLine(++a);
            Console.WriteLine(a++);
            Console.WriteLine(a--);
            Console.WriteLine(--a);
        }

    }

}