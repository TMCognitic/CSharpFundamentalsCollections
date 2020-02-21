using System;
using System.Collections;

namespace CSharpFundamentalsCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercice 1
            {
                int maxValue;
                do
                {
                    Console.Write("Jusqu'a quelle valeur voulez-vous trouver les nombres premiers ? : ");
                }
                while (!int.TryParse(Console.ReadLine(), out maxValue) && maxValue > 0);

                ArrayList primes = new ArrayList();

                int nombre = 2;

                while (nombre < maxValue)
                {
                    bool isPrime = true;
                    int racine = (int)Math.Sqrt(nombre);

                    for (int index = 0; racine > 1 && (int)primes[index] <= racine && isPrime; index++)
                    {
                        if (nombre % (int)primes[index] == 0)
                            isPrime = false;
                    }

                    if (isPrime)
                    {
                        primes.Add(nombre);
                    }

                    nombre++;
                }

                foreach (int prime in primes)
                {
                    Console.WriteLine(prime);
                }
            }
            #endregion
        }
    }
}
