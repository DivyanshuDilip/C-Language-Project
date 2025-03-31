using System;

namespace CSharpPrograms
{
    class StringProgram
    {
        static void Main(string[] args)
        {
            // Reverse String

            string name = "Divyanshu";

            // There is no class name charAt() which was there in Java to store each character in 
            // C# we have to use ToCharArray() which store each character in array
            char[] charArray = name.ToCharArray();

            Console.WriteLine(charArray[0]);

            Array.Reverse(charArray);

            // Again we have to convert array into String

            string reversedStr = new string(charArray);

            Console.WriteLine(reversedStr);

            string upperCase = name.ToUpper();
            Console.WriteLine(upperCase);

            string lowerCase = name.ToLower();
            Console.WriteLine(lowerCase);
        }
    }
}