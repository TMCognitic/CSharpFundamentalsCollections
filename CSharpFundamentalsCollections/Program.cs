using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpFundamentalsCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercice 1
            {
                //int maxValue;
                //do
                //{
                //    Console.Write("Jusqu'a quelle valeur voulez-vous trouver les nombres premiers ? : ");
                //}
                //while (!int.TryParse(Console.ReadLine(), out maxValue) && maxValue > 0);

                //ArrayList primes = new ArrayList();

                //int nombre = 2;

                //while (nombre < maxValue)
                //{
                //    bool isPrime = true;
                //    int racine = (int)Math.Sqrt(nombre);

                //    for (int index = 0; racine > 1 && (int)primes[index] <= racine && isPrime; index++)
                //    {
                //        if (nombre % (int)primes[index] == 0)
                //            isPrime = false;
                //    }

                //    if (isPrime)
                //    {
                //        primes.Add(nombre);
                //    }

                //    nombre++;
                //}

                //foreach (int prime in primes)
                //{
                //    Console.WriteLine(prime);
                //}
            }
            #endregion

            #region Exercice 2
            {
                //int count;
                //do
                //{
                //    Console.Write("Combien de nombre premier voulez-vous ? : ");
                //}
                //while (!int.TryParse(Console.ReadLine(), out count) && count > 0);

                //List<int> primes = new List<int>();
           
                //for (int i = 0, nombre = 2; i < count; nombre++)
                //{
                //    bool isPrime = true;
                //    int racine = (int)Math.Sqrt(nombre);

                //    for (int index = 0; racine > 1 && primes[index] <= racine && isPrime; index++)
                //    {
                //        if (nombre % primes[index] == 0)
                //            isPrime = false;
                //    }

                //    if (isPrime)
                //    {
                //        primes.Add(nombre);
                //        i++;
                //    }
                //}

                //foreach (int prime in primes)
                //{
                //    Console.WriteLine(prime);
                //}
            }
            #endregion

            #region Exercice 3
            {
                string nombre1 = "792281625142643375935439503357922816251426433759354395033579228162514264337593543950335";
                string nombre2 = "7922816251426433759354395033579228162514264337593543950335";

                Stack<int> stackNombre1 = new Stack<int>();
                foreach (char c in nombre1)
                {
                    stackNombre1.Push(c - 48);
                }

                Stack<int> stackNombre2 = new Stack<int>();
                foreach (char c in nombre2)
                {
                    stackNombre2.Push(int.Parse(c.ToString()));
                }

                int report = 0;
                string resultat = "";

                while(stackNombre1.Count > 0 || stackNombre2.Count > 0)
                {
                    int chiffre1 = (stackNombre1.Count > 0) ? stackNombre1.Pop() : 0;
                    int chiffre2 = (stackNombre2.Count > 0) ? stackNombre2.Pop() : 0;

                    int addition = chiffre1 + chiffre2 + report;
                    report = addition/10;
                    int valeur = addition%10;

                    resultat = valeur + resultat;
                }

                if(report > 0)
                    resultat = report + resultat;

                Console.WriteLine(resultat);

            }
            #endregion
        }
    }
}
