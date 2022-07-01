using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_sharp_assignment_3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            double r;
            double pi = 3.14;
            double side;
            double height;
            double b;

            double sideA;
            double sideB;
            double sideC;


            Console.WriteLine("Enter radius of the circle:");
            r = double.Parse(Console.ReadLine());
            s = new Circle { area = pi * r * r, parameter = 2 * pi * r };

            Console.WriteLine("Area of the circle: " + s.area);
            Console.WriteLine("parameter of cicle: " + s.parameter);
            Console.ReadKey();
            Console.WriteLine("\nEnter sides for square:");
            side = double.Parse(Console.ReadLine());
            s = new Square { area = side * side, parameter = side * side * side * side };
            Console.WriteLine("Area of the square: " + s.area);
            Console.WriteLine("parameter of square: " + s.parameter);
            Console.ReadKey();
            Console.WriteLine("\nEnter base for triangle:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter height for triangle:");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter side A for triangle:");
            sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter side B for triangle:");
            sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter side C for triangle:");
            sideC = double.Parse(Console.ReadLine());
            s = new Square { area = 0.5 * b * height, parameter = sideA * sideB * sideC };
            Console.WriteLine("Area of the triangle: " + s.area);
            Console.WriteLine("parameter of triangle: " + s.parameter);
            Console.ReadKey();




        }
    }

    interface Shape
    {
        double area { get; set; }
        double parameter { get; set; }

    }

    public class Circle : Shape
    {
        public double area { get; set; }
        public double parameter { get; set; }


    }

    public class Square : Shape
    {
        public double area { get; set; }
        public double parameter { get; set; }

    }
    public class Triangle : Shape
    {
        public double area { get; set; }
        public double parameter { get; set; }

    }


}


