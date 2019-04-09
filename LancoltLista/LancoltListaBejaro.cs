using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancoltLista
{
    public class LancoltListaBejaro<T> : IEnumerator
    {
        LancoltListaElem<T> fej = new LancoltListaElem<T>();
        LancoltListaElem<T> aktualis;

        public LancoltListaBejaro(LancoltListaElem<T> fej)
        {
            this.fej = fej;
            aktualis = null;
        }

        public object Current
        {
            get
            {
                if (aktualis != null)
                    return aktualis.Tartalom;
                return null;
            }
        }

        public bool MoveNext()
        {
            if(aktualis == null)
            {
                aktualis = fej.Kovetkezo;
                return aktualis != null;
            }
            if(aktualis.Kovetkezo == null)
            {
                return false;
            }
            aktualis = aktualis.Kovetkezo;
            return true;
        }

        public void Reset()
        {
            aktualis = null;
        }
    }
}
