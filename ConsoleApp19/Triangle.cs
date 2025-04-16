using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Triangle : IShape
    {
        private int side1, side2, side3;

        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }
        public int Side3 { get => side3; set => side3 = value; }

        public Triangle(int side1, int side2, int side3)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        public double Area()
        {
            double p = Perimeter() / 2.0;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public double Perimeter() => Side1 + Side2 + Side3;

        public static Triangle Input()
        {
            Console.WriteLine("Треугольник:");
            Console.Write("Первая сторона: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("Вторая сторона: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("Третья сторона: ");
            int side3 = int.Parse(Console.ReadLine());
            return new Triangle(side1, side2, side3);
        }

        public override string ToString()
        {
            return $"Треугольник со сторонами {Side1}, {Side2} и {Side3}:\n" +
                   $"Площадь - {Area():f2}, Периметр - {Perimeter():f2}";
        }
    }
}
