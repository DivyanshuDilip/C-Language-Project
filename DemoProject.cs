namespace CSharpPrograms
{
    class DemoProject
    {

        public static void Main(string[] args)
        {
            string Pincode = "12346";


            // If Condition
            if (Pincode == "12345")
            {
                Console.WriteLine(Pincode);
            }
            else
            {
                Console.WriteLine("Wrong Pincode");
            }

            // While Loop

            int i = 1;

            while (i <= 10)
            {
                Console.Write(i);
                i++;
            }

        }
    }
}
