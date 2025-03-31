using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace CSharpPrograms
{
    class OOPConcept
    {
        // One Real Time Example To Under Class And Object 

        // Properties Stored in Variable
        string price = "8000";
        string storage = "8 GB RAM";

        string color = "White";

        // Behaviour stored in Method

        public void Calling()
        {
            Console.WriteLine("Calling Is Available");
        }

        public void Music()
        {
            Console.WriteLine("Hear Songs");
        }


        public static void Main(string[] args)
        {
            // Creating Object For A Class To Call Properties And Methods

            OOPConcept opps = new OOPConcept();

            opps.Calling();

            opps.Music();

            Console.WriteLine(opps.color);
            Console.WriteLine(opps.price);






        }



    }
}