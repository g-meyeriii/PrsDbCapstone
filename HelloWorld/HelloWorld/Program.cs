using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myname = "George";

            //string message = "My name is " + myname;

            //string capsmessage = message.ToUpper();

            //string lowermessage = message.ToLower();


            //Console.WriteLine(lowermessage);

            //Console.Read();

            // implicit conversion
            //int num = 1290532;
            //long bignum = num;

            //Console.WriteLine(bignum);
            //Console.Read();

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
           
            // explicit conversion
            // cast double to int;
            myInt = (int)myDouble;

            // typeconversion
            string myString = myDouble.ToString(); // "13.37"
            string myFloatString = myFloat.ToString();

            bool sunIsShining = true;

            string myBoolString =sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.Read();
        }

    }
}
