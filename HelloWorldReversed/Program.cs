using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi;

            Console.WriteLine("Hello, World!");
            string text = "Hello, World!";

            for (int i = text.Length - 1; i >= 0; i--)
            {             
                Console.Write(text[i]);
            }
        }
    }
}
