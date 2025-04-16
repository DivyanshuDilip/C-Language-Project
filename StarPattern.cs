using System;

namespace CSharpPrograms
{
    class StarPattern
    {
        static void Main(string[] args)
        {
            /*// * 
              // * * 
              // * * * 
              // * * * * 
              // * * * * * 
              // 1st For Loop Is For Number Of Rows
              for (int i = 1; i <= 5; i++)
              {

                  for (int j = 1; j <= i; j++)
                  {
                      Console.Write("*" + " ");
                  }
                  Console.WriteLine();
              }*/

            /* // &* &* &* &* &* 
            // &* &* &* &* 
            // &* &* &* 
            // &* &* 
            // &* 
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("&*" + " ");
                }
                Console.WriteLine();
            }*/

            // Will Try To Create Triangle
           /* //      * 
            //     * * 
            //    * * * 
            //   * * * * 
            //  * * * * * 

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");

                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*" + " ");

                }
                Console.WriteLine();
            }*/

        }
    }
}