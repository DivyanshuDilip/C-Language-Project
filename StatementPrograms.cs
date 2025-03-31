using System.Net;

namespace CSharpPrograms
{
    class StatementPrograms
    {
        public static void Main(string[] args)
        {
            /*// Break Statement

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.Write(i);

            }*/
            /* // Continue Statement

             for (int i = 1; i <= 10; i++)
             {

                 if (i == 4 || i == 9)
                 {
                     continue;

                 }
                 Console.WriteLine(i);

             }*/
            /*// Return Statement

            string r = Name("Divyanshu", "Jain");
            Console.WriteLine(r);*/

            // GoTo Statement [We can use this instead of looping statement]

            //     int i = 1;
            // Go:
            //     if (i <= 10)
            //     {
            //         Console.WriteLine(i);
            //         i++;
            //         goto Go;
            //     }

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                { break; }
                Console.WriteLine(i);
                goto down;
            }
            Console.WriteLine("Divyanshu");
        down:
            Console.WriteLine("Anshu");
        }

        /*static string Name(string a, string b)
        {
            return a + " " + b;
        }*/
    }

}