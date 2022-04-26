using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetRepeat
{
        public class Employee
        {
            private string name;
            public string Name
            {
                get { return name; }
                set
                {
                    name = value.ToUpper();
                }
            }
            private int age;
            public int Age
            {
                get { return age; }
                set
                {
                    if (value >= 18 && value <= 70)
                        age = value;
                    else
                        Console.WriteLine("Человек несовершеннолетний либо же на пенсии");
                }
            }
            private int sal;
            public int Sal
            {
                get { return sal; }
                set
                {
                    if (value > 0)
                        sal = value;
                    else
                        Console.WriteLine("Зарплата не может быть отрицательной");
                }
            }

        }
}
