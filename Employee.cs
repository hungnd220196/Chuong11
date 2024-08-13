using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong11
{
    internal class Employee : IComparable
    {
        public string Name;
        public int Number;
        public Employee(string Name, int Number) 
        {
            this.Name = Name;
            this.Number = Number;
        }
        public override string ToString()
        {
            return $"Name is {Name}, Number is: {Number}";
        }
        public int Compare(object obj1, object obj2 )
        {
            Employee em1 = (Employee)obj1;
            Employee em2 = (Employee)obj2;
            if (em1.Number<em2.Number)
            {
                return -1;
            }else if (em1.Number > em2.Number)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int CompareTo(object obj2)
        {
            return Compare(this, obj2);
        }
    }
}
