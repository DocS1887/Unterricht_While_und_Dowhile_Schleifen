using System;

namespace WhileUndDoWhileSchleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Aufbau der for-Schleife
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            int j = 10;
            while (j < 10) // kopf-gesteuerte Schleife
            {
                Console.Write(j + " ");
                j++;
            }

            Console.WriteLine();
            j = 10;
            do // fuss-steuerte Schleife
            {
                Console.Write(j + " ");
                j++;

            } while (j < 10);

            */

            // Anforderung: Gib alle Zahlen von 1 bis 100, die durch 3 teilbar sind.
            // Gib an, wie viele Zahlen gefunden wurden
            // Weitere Variante: Gebt alle Zahlen aus, die sowohl durchc 3, als auch durch 5 teilbar sind


            int counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(i + " ");
                    counter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Anzahl gefundener Zahen: {counter}");

            // Lösung mit der while-Schleife
            Console.WriteLine();
            counter = 0;
            int j = 1;
            while (j <= 100)
            {
                if (j % 3 == 0 && j % 5 == 0)
                {
                    Console.Write(j + " ");
                    counter++;
                }
                j++;

            }
            Console.WriteLine();
            Console.WriteLine($"Anzahl gefundener Zahen: {counter}");

            // Realisiert das obige Bsp. mit einer do-while-Schleife

        }
    }
}
