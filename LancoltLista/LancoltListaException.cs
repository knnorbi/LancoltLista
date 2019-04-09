using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancoltLista
{
    public class LancoltListaException<T> : Exception
    {
        LancoltLista<T> lista;

        public LancoltListaException(LancoltLista<T> lista, string uzenet) : base(uzenet)
        {
            this.lista = lista;
        }
    }
}
