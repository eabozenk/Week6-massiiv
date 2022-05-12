using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            Console.WriteLine("Hello World!");
            string text = "'Hello World!'".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;


            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'h')
                {
                    hCounter++;
                }
            }
            if (hCounter != 1)
            {
                Console.WriteLine($"Lauses {text} on {hCounter} 'h' tähte");
            }
            else
            {
                Console.WriteLine($"Lauses {text} on {hCounter} 'h' täht");
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'o')
                {
                    oCounter++;
                }
            }
            if (oCounter != 1)
            {
                Console.WriteLine($"Lauses {text} on {oCounter} 'o' tähte");
            }
            else
            {
                Console.WriteLine($"Lauses {text} on {oCounter} 'o' täht");
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'l')
                {
                    lCounter++;
                }
            }
            if (lCounter != 1)
            {
                Console.WriteLine($"Lauses {text} on {lCounter} 'l' tähte");
            }
            else
            {
                Console.WriteLine($"Lauses {text} on {lCounter} 'l' täht");
            }


        }
    }
}

