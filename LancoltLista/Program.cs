using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancoltLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> asd = new List<int>();
            //List<DateTime> asdasd = new List<DateTime>();
            //List<Object> asdasdasd = new List<Object>();

            LancoltLista<int> lancoltLista = new LancoltLista<int>();
            lancoltLista.BeszurasAzElejere(1);
            lancoltLista.BeszurasAzElejere(2);
            lancoltLista.BeszurasAVegere(3);
            lancoltLista.TorlesAzElejerol();
            lancoltLista.TorlesAVegerol();

            Console.WriteLine(lancoltLista[0]);
            lancoltLista[0] = 2;
            //Console.WriteLine(lancoltLista[1]);

            lancoltLista.BeszurasAzElejere(4);
            lancoltLista.BeszurasAzElejere(5);
            lancoltLista.BeszurasAzElejere(6);

            foreach (int elem in lancoltLista)
            {
                Console.WriteLine(elem);
            }

            LancoltLista<int> lancoltLista2 = new LancoltLista<int>();

            int a = lancoltLista.CompareTo(lancoltLista2);

            List<LancoltLista<int>> lista = new List<LancoltLista<int>>();
            lista.Add(lancoltLista2);
            lista.Add(lancoltLista);
            lista.Sort();

            int[] asd = new int[] { 2, 1 };
            Array.Sort(asd);

            //Dummy d = new Dummy(10);
            //foreach (var item in d)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }
    }
}
