using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Circle c = new Circle ();
            c.Rad = 10;
            Console.WriteLine("D круга: {0}",c.D);
            c.Square();
            c.Len();*/

            Bank b = new Bank();
            Employee emp = new Employee { Name = "ренат", Age = 19, Sal = 666 };
            b.Empl.Add(emp);
            emp = new Employee { Name = "Денис", Age = 21, Sal = 777 };
            b.Empl.Add(emp);
            Console.WriteLine(b);
        }
    }
}
