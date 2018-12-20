using System;

namespace liczbpierw
{
    class Liczbpierw
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                tablica[i] = rand.Next(1, 60);
            }
            foreach (int x in tablica)
            {
                Console.Write("{0, 8}", x);
            }

            Console.WriteLine();
             
            int pierwsze1 = 0, pierwsze2 = 0, razem = 0, wynik;                      
            for (int i = 0; i < tablica.Length; i++)
            {               
                if (tablica[i] == 2)
                {
                    pierwsze1 += 1;
                }
                
                if (tablica[i] > 2)
                {
                    wynik = 1;                  
                    int j = 2;
                    while (j < tablica[i])
                    {
                        if ((tablica[i] % j) == 0)
                        {
                            wynik = 0;
                        }
                        j++;                
                    }
                    if (wynik == 1)
                    {
                        pierwsze2 += 1;
                    }                    
                }
            }
            razem = pierwsze1 + pierwsze2;
            Console.WriteLine("Liczb pierwszych w tablicy jest: {0}", razem);

            Console.ReadKey();
        }
    }
}
