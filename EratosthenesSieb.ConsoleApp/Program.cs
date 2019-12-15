using System;

namespace EratosthenesSieb.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperMax;
            int touches = 0;
            int outputCounter = 0;

            Console.WriteLine("Sieb des Eratosthenes");
            Console.WriteLine("=====================");
            
            do
            {
                Console.Write("Bis zu welcher Zahl wollen Sie Primzahlen ausgeben: ");
                upperMax = Convert.ToInt32(Console.ReadLine());
            } 
            while (upperMax < 2);
            
            bool[] isNotPrime = new bool[upperMax + 1];

            for(int i = 2; i < isNotPrime.Length; i++)
            {
                for(int j = i; j < isNotPrime.Length; j++)
                {
                    if (j * i < isNotPrime.Length)
                    {
                        isNotPrime[j * i] = true;
                        touches++;
                    }
                }
            }

            Console.WriteLine("Primzahlen von 1 - {0}", upperMax);

            for(int k = 2; k < isNotPrime.Length; k++)
            {
                if (!isNotPrime[k])
                {
                    Console.WriteLine(k);
                    outputCounter++;
                    if (outputCounter % 22 == 00)
                    {
                        Console.WriteLine("Bitte Eingabetaste zum Fortfahren drücken!");
                        Console.ReadKey();
                    }
                }
            }

            Console.WriteLine("Zugriffe: {0}", touches);
            Console.ReadKey();




            
        }
    }
}
