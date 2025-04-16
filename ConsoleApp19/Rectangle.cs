using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Rectangle : IShape
    {
        private int side1, side2;

        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }

        public Rectangle(int side1, int side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public double Area() => Side1 * Side2;

        public double Perimeter() => 2 * (Side1 + Side2);

        public static Rectangle Input()
        {
            Console.WriteLine("Прямоугольник:");
            Console.Write("Первая сторона: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("Вторая сторона: ");
            int side2 = int.Parse(Console.ReadLine());
            return new Rectangle(side1, side2);
        }

        public override string ToString()
        {
            return $"Прямоугольник со сторонами {Side1} и {Side2}:\n" +
                   $"Площадь - {Area():f2}, Периметр - {Perimeter():f2}";
        }
    }
}
