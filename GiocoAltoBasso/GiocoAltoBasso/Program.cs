using System;

namespace GiocoAltoBasso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Se vuoi finire il gioco, digitare 0");

            //generatore di numeri casuali tra 1 e 100

            while (numero != )
            {
                Console.WriteLine("Inserisci un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 100)
                {
                    Console.WriteLine("Il numero inserito è troppo alto");
                }
                else if (numero < 1)
                {
                    Console.WriteLine("Il numero inserito è troppo basso");
                }
                else if (numero == 0)
                {
                    Console.WriteLine("Hai finito il gioco");
                }
            }
        }
    }
}
