using System;
using System.Collections.Generic;
using System.Text;

namespace Composizione
{
    internal class CPunto
    {
        private int _x;
        private int _y;

        /* come richiesta dalla consegna, rimuovo le proprierty, e chiamo col ToString() ogni classe
        public int X
        {
            get { return _x; }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
            }
        }
        */

        public CPunto(){
            X=0;
            Y=0;
        }
        public CPunto(int x, int y)
        {
            X = x;
            Y = y;

        }
          public override string ToString()
        {
            return ("X:"+_x+"Y:"+_y);
        }
    }
}
