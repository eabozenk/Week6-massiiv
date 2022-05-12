using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime;
            //programm kontrollib andmete pikkust;
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi;

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();
           
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");
            Console.WriteLine($"Sinu perekonnanimes on {lastName.Length} sümbolit.");

            if(firstName.Length > lastName.Length)
            {
                Console.WriteLine("Eesnimi on pikem kui perekonnanimi.");
            }
            else
            {
                Console.WriteLine("Perekonnanimi on pikem kui eesnimi");
            }
        }
    }
}
