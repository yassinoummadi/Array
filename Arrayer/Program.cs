using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {


            /*Övning 1
            string[] lista = new string[10];

            for (int x = 0; x < 10; x++)
            {

                Console.WriteLine("Mata in ett namn: " + " ");
                lista[x] =  Console.ReadLine();
                
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(lista[i]);
            }
            */

            /* Övning 2
            int[] lista = new int[10];

            for (int x = 0; x < 10; x++)
            {

                Console.WriteLine("Mata in ett tal: ");
                lista[x] = int.Parse(Console.ReadLine());

            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(lista[i]);
            }
            */

            /* Övning 3
            int[] lista = { 12, 5, 6, 1, 2, 3, -2, -7, 0 };

            int x = 0;
            
            for (int i = 0; i < lista.Length; i++)
            {
                for (int j = i + 1; j < lista.Length; j++)
                {
                    if (lista[i] > lista[j])
                    {
                        x = lista[j];
                        lista[j] = lista[i];
                        lista[i] = x;
                    }
                }
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();
            */

            

        }
    }
}
