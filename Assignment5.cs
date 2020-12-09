using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncCodeWithDelegates
{
    class Assignment
    {

        static void Main(string[] args)
        {
            Func<decimal, decimal, decimal, decimal> si = (P, N, R) => P + N + R;
            Console.WriteLine(si(1000, 2, 3));
            Console.ReadLine();

            Func<int, int, bool> p = IsGreater;
            Console.WriteLine(p(10, 20));
            Console.ReadLine();

            Func<Employee, decimal> f = (s) => s.SALARY + 1000;
            Employee e1 = new Employee(3000);
            Console.WriteLine(f(e1));
            Console.ReadLine();

            Predicate<int> e = IsEven;
            Console.WriteLine(e(20));
            Console.ReadLine();

            Predicate<Employee> pe = (s1) => s1.SALARY > 10000;
            Console.WriteLine("enter salary  ");
            decimal sal = Convert.ToDecimal(Console.ReadLine());
            Employee e2 = new Employee(sal);
            Console.WriteLine(pe(e2));
            Console.ReadLine();
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        static bool IsGreater(int a, int b)
        {
            return a > b;
        }
    }

    public class Employee
    {
        decimal salary;

        public decimal SALARY
        {
            get { return salary; }
            set
            {
                this.salary = value;
            }

        }

        public Employee(decimal sal = 2000)
        {
            this.SALARY = sal;
        }
    }
}
