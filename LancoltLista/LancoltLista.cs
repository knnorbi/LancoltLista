using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancoltLista
{
    public class LancoltLista<T> : IEnumerable
    {
        LancoltListaElem<T> fej;

        public LancoltLista()
        {
            fej = new LancoltListaElem<T>();
        }

        public void BeszurasAzElejere(T ertek)
        {
            LancoltListaElem<T> ujElem = new LancoltListaElem<T>(ertek);
            ujElem.Kovetkezo = fej.Kovetkezo;
            fej.Kovetkezo = ujElem;
        }

        public void BeszurasAVegere(T ertek)
        {
            LancoltListaElem<T> aktualisElem = fej;
            while(aktualisElem.Kovetkezo != null)
            {
                aktualisElem = aktualisElem.Kovetkezo;
            }
            aktualisElem.Kovetkezo = new LancoltListaElem<T>(ertek);
        }

        public override string ToString()
        {
            string vissza = "";

            // Bejárás
            LancoltListaElem<T> aktualisElem = fej.Kovetkezo;
            while (aktualisElem != null)
            {
                if(vissza != "")
                {
                    vissza += ", ";
                }
                vissza += aktualisElem.Tartalom;
                aktualisElem = aktualisElem.Kovetkezo;
            }

            return vissza;
        }

        public int Meret
        {
            get
            {
                int darab = 0;

                // Bejárás
                LancoltListaElem<T> aktualisElem = fej.Kovetkezo;
                while (aktualisElem != null)
                {
                    darab++;
                    aktualisElem = aktualisElem.Kovetkezo;
                }

                return darab;
            }
        }

        public void TorlesAzElejerol()
        {
            if(fej.Kovetkezo == null)
            {
                throw new LancoltListaUresExecption<T>(this, "Üres listából nem lehet törölni!");
            }

            fej.Kovetkezo = fej.Kovetkezo.Kovetkezo;
        }

        public void TorlesAVegerol()
        {
            if(fej.Kovetkezo == null)
            {
                throw new LancoltListaUresExecption<T>(this, "Üres listából nem lehet törölni!");
            }

            LancoltListaElem<T> aktualisElem = fej;
            while(aktualisElem.Kovetkezo.Kovetkezo != null)
            {
                aktualisElem = aktualisElem.Kovetkezo;
            }
            aktualisElem.Kovetkezo = null;
        }

        LancoltListaElem<T> GetListaElemByIndex(int index)
        {
            if (fej.Kovetkezo == null)
            {
                throw new LancoltListaUresExecption<T>(this, "Üres listát nem lehet indexelni!");
            }
            if (index >= Meret || index < 0)
            {
                // TODO
                throw new IndexOutOfRangeException("Az index a láncolt lista határain túlra mutatott!");
            }

            int i = 0;
            LancoltListaElem<T> aktualisElem = fej.Kovetkezo;
            while (i < index)
            {
                i++;
                aktualisElem = aktualisElem.Kovetkezo;
            }
            return aktualisElem;
        }

        public IEnumerator GetEnumerator()
        {
            return new LancoltListaBejaro<T>(fej);
        }

        public T this[int index]
        {
            get { return GetListaElemByIndex(index).Tartalom; }
            set { GetListaElemByIndex(index).Tartalom = value; }
        }
    }
}
