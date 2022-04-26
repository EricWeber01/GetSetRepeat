using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetRepeat
{
    class Circle
    {
        private int rad;
        public int Rad
        {
            get { return rad; }
            set
            {
                if (value > 0)
                    rad = value;
                else
                    Console.WriteLine("Неправильный ввод");
            }
        }
        private int d;
        public int D
        {
            get { return rad * 2; }
        }
        public void Square()
        {
            Console.WriteLine("S круга: " + (float)3.14 * rad * rad);
        }
        public void Len()
        {
            Console.WriteLine("L круга: " + (float)2 * 3.14 * rad);
        }
    }
}