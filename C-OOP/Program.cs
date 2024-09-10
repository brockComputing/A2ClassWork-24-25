using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    class Employee
    {
        private string name;
        private string title;
        protected double rate;
        public string addresss;

        public Employee(string name)
        {
            this.name = name;
        }

        public Employee()
        {
            name = "ttttttttt";
        }

        public virtual void UpdateRate(double percentAmount)
        {
            rate = (percentAmount / 100 * rate) + rate;
        }
        public void SetName(string thename)
        {
            name = thename;
        }
        public double GetRate()
        {
            return rate;
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

    class Grunt : Employee
    {
        public string colourOfOveralls;
        public override void UpdateRate(double percentAmount)
        {
            base.UpdateRate(percentAmount);
        }
        public void SetOverallColour(string theColour)
        {
            rate = 45.7;
            
            colourOfOveralls = theColour;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("beb");
            Employee emp2 = new Employee("dave");
            Employee emp3 = new Employee();
            Employee  emp4 = new Grunt();
            
            emp.SetName("ted");
        }
    }
}
