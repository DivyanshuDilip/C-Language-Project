namespace CSharpPrograms
{
    class Program
    {

        public static void Main(string[] args)
        {
            int a, b, r;

            Console.Write("Add Two Numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            r = a + b;

            Console.Write("Total Sum :" + r);

        }
    }
}



