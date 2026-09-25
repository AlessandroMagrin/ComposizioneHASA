using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Composizione
{
    internal class CCerchio
    {
        private double _raggio;
       
        private CPunto _centro;
        /*
        public double Raggio
        {
            get { return _raggio; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Il valore non è valido");
                }
                _raggio = value;
            }
        }
        */

        public CPunto Centro
        {
            get { return _centro; }
            set { _centro = value; }
        }
       

        public CCerchio()
        {
            Raggio = 1;
            Centro = new CPunto();
           

        }

        public CCerchio(double raggio, int x, int y)
        {
            Raggio = raggio;
            Centro = new CPunto(x,y);
           

        }

        public override string ToString()
        {
            return ("Raggio:"+_raggio+ "Centro:" +_centro.ToString()");
        }


        
    }
}
