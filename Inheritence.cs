// Inheritence helps one class to inherits properties and functionalities from anothe class.
using System;

namespace Project
{
    class FirstInheritence
    {
        public void Speak()
        {
            Console.WriteLine("We can speak");
        }

    }

    class SecondClass : FirstInheritence
    {
        public void Music()
        {
            Console.WriteLine("We can hear the music");
        }

    }

    class Inheritence
    {
       public static void Main(string[] args)
        {
            SecondClass second = new SecondClass();

            second.Speak();
            second.Music();

        }
    }
}