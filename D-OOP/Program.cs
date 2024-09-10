using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    class Employee
    {
        private string name;
        private string title;
        private double rate;

        public Employee(string title)
        {
            this.title = title;
        }
        public Employee()
        {
            name = "xxxxxx";
        }

        public void UpdateRate(double percentAmount)
        {
            rate = (percentAmount / 100 * rate) + rate;
        }

        public double GetRate()
        {
            return rate;
        }
        public void SetName(string theName)
        {
            name = theName;
        }
        public string Getname()
        {
            return name;
        }

        public string getTitle()
        {
            return title;
        }

    }

    class Cleaner : Employee
    {
        private int noMops;
        public int GetNoMops()
        {
            return noMops;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("mr");
            Employee emp2 = new Employee();
            Cleaner cln1 = new Cleaner();
           
            Console.WriteLine(emp2.Getname());
            emp1.SetName("ted");
            

        }
    }
}
