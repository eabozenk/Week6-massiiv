using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab lauses "Don't Panic" kõik 'o' tähed nulliga - 0;
            //programm asendab kõik 'a' tähed samas laused 4-ga;

            Console.WriteLine("Don't Panic");
            string text = "Don't Panic";                    

            text = text.Replace('o', '0');
            text = text.Replace('a', '4');
            Console.WriteLine($"Asendustega: {text}");
        }
    }
}
