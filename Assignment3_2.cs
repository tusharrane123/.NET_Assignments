using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Day5Assi3
    {
        static void Main8()
        {
            
            
            Student[] arr = new Student[2];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter name,roll no ,marks");
                string nm = Console.ReadLine();
                int roll = Convert.ToInt32(Console.ReadLine());
                //decimal marks = Convert.ToInt128(Console.ReadLine());
                decimal mk = Decimal.Parse(Console.ReadLine());
                //Student s1 = new Student();
                  Student s1=new Student(mk,nm,roll);
                  arr[i] = s1;
                  //arr[i].Accep\

            }
            foreach(Student s in arr)
            {
                s.Show();
            }
            Console.ReadLine();
        }
    }
    public struct Student
    {
        string Name;
        int RollNo;
        decimal Marks;
        public string NAME
        {
            set
            {
                if(value != null)
                Name = value;
                else
                    Console.WriteLine("Enter valid name");
            }
            get
            {
                return Name;
            }
        }
        public int ROLLNO
        {
            set
            {
                if (value != 0)
                    RollNo = value;
                else
                    Console.WriteLine("Enter valid roll no");
            }
            get
            {
                return RollNo;
            }
        }
        public decimal MARKS
        {
            set
            {
                if (value > 40)
                    Marks = value;
                else
                {
                    Console.WriteLine(" Not eligible for passing");
                }
            }
            get
            {
                return Marks;
            }
        }

        public Student(decimal Marks, string Name, int RollNo)
        {
            this.Name = "";
            this.Marks = 0;
            this.RollNo = 0;
            this.NAME = Name;
           this.ROLLNO = RollNo;
            this.MARKS = Marks;
        }
        public void Show()
        {
            Console.WriteLine("The Emp Detals are: {0} , {1} , {2} ",this.ROLLNO,this.NAME,this.MARKS);
        }

    }
}
