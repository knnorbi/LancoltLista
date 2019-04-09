using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancoltLista
{
    public class LancoltListaUresExecption<T> : LancoltListaException<T>
    {
        public LancoltListaUresExecption(LancoltLista<T> lista, string uzenet) : base(lista, uzenet) { }
    }
}
