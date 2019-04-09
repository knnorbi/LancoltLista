using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancoltLista
{
    public class LancoltListaElem<T>
    {
        public T Tartalom;
        public LancoltListaElem<T> Kovetkezo;

        public LancoltListaElem()
        {
            Tartalom = default(T);
            Kovetkezo = null;
        }

        public LancoltListaElem(T ertek)
        {
            Tartalom = ertek;
            Kovetkezo = null;
        }

        public override string ToString()
        {
            return Tartalom.ToString();
        }
    }
}
