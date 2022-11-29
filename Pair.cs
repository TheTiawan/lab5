using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace lab5
{
    public class Pair
    {
        private int _first;
        private int _second;

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }

        public int First
        {
            get { return _first; }
            set
            {
                if (value % 2 != 0) throw new ArgumentException("Число должно быть четным");
                _first = value;
            }
        }

        public int Second
        {
            get { return _second; }
            set
            {
                if (value % 2 != 0) throw new ArgumentException("Число должно быть четным");
                _second = value;
            }
        }

        public Pair Multiplicate(Pair pair)
        {
            return new Pair(First * pair.First, Second * pair.Second);
        }

        public Pair Doubling (Pair pair)
        {

            return new Pair(pair.First * 2, pair.Second * 2);

        }
    }
}
