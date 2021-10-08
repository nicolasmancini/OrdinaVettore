using System;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creazione e popolamento del vettore di interi
            int [] vettore = new int [10] { 11, 55, -9, 7, 74, 147, -87, 6, 0, 18};

            //Invoco il metodo per l'ordinamento
            ordina(vettore);

            for (int i = 0; i < 10; i++)
                Console.WriteLine(vettore[i]);

            Console.ReadKey();
        }

        //Metodo per l'ordinamento
        static void ordina (int[] vettore)
        {
            Array.Sort(vettore);
        }

     
    }
}
