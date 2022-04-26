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
        public override string ToString()
        {
            return $"Name: {this.Name}\nAge: {this.Age}\nSalary: {this.Sal}\n";
        }
    }
    public class Bank
    {
        private List<Employee> empl = new List<Employee>();
        public List<Employee> Empl
        {
            get
            {
                return empl;
            }
            set
            {
                Employee item = new Employee();
                empl.Add(item);
            }
        }
        /* public override bool Equals(object obj)
         {
             return obj is Bank bank &&
                    EqualityComparer<List<Employee>>.Default.Equals(Empl, bank.Empl);
         }
         public override int GetHashCode()
         {
             return 400168067 + EqualityComparer<List<Employee>>.Default.GetHashCode(Empl);
         }*/
        public override string ToString()
        {
            string res = "";
            foreach (Employee item in Empl)
            {
                res += item;
            }
            return $"{res}";
        }
    }
}