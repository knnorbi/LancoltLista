﻿using System;
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

            Console.ReadKey();
        }
    }
}
