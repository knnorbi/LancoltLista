using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancoltLista
{
    class Dummy : IEnumerable
    {
        int n;

        public IEnumerator GetEnumerator()
        {
            return new DummyIterator(n);
        }

        public Dummy(int n)
        {
            this.n = n;
        }
    }

    class DummyIterator : IEnumerator
    {
        int n, i;
        Random random;

        public DummyIterator(int n)
        {
            this.n = n;
            random = new Random();
            i = 0;
        }

        int current;

        public object Current { get { return current; } }

        public bool MoveNext()
        {
            if(i < n - 1)
            {
                current = random.Next();
                i++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            i = 0;
            current = 0;
        }
    }
}
