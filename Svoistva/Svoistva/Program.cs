using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svoistva
{
    class IntNumber
    {
        private int d;
        public IntNumber(int _d)
        {
            d = _d;
        }
        public int Number
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("d = {0}", d);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IntNumber number = new IntNumber(5);
            number.Display(); 
            number.Number = 25;
            number.Display(); 
            int t;
            t = number.Number; 
            Console.WriteLine("t = {0}", t);
        }
    }
}