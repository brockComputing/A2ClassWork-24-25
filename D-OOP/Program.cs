using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public abstract class Shape
    {
        public string Name { get; private set; }

        public Shape(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name} - Area: {GetArea():N2}, Perimeter: {GetPerimeter():N2}";
        }
    }

    public class Ellipse : Circle
    {
        public Ellipse(string name, double radius) : base(name, radius)
        {
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    #region class work
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
    #endregion 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region class work
            Employee emp1 = new Employee("mr");
            Employee emp2 = new Employee();
            Cleaner cln1 = new Cleaner();
           
            Console.WriteLine(emp2.Getname());
            emp1.SetName("ted");
            #endregion 


        }
    }
}
