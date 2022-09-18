using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalnaProvjera_1.dio_9.zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 4,7,45,3,11,25,1};
            lista = lista.OrderBy(i => i).ToList();

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadKey();
        }
    }
}
