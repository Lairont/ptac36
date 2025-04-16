using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Circle : IShape
    {
        private int radius;
        public int Radius { get => radius; set => radius = value; }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public double Area() => Math.PI * Radius * Radius;

        public double Perimeter() => 2 * Math.PI * Radius;

        public static Circle Input()
        {
            Console.WriteLine("Круг:");
            Console.Write("Введите радиус: ");
            int radius = int.Parse(Console.ReadLine());
            return new Circle(radius);
        }

        public override string ToString()
        {
            return $"Круг с радиусом {Radius}:\n" +
                   $"Площадь - {Area():f2}, Периметр - {Perimeter():f2}";
        }
    }
}
