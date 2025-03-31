using System;

namespace CSharpPrograms
{
    class Encapsulation
    {
        private int atmPin;

        public int getReturn()
        {
            return atmPin;
        }

        public void setValue(int pin)
        {
            atmPin = pin;

        }

        public static void Main(string[] args)
        {
            Encapsulation en = new Encapsulation();

            en.setValue(1234);

            Console.Write("ATM Pin Is:" + en.getReturn());




        }
    }
}