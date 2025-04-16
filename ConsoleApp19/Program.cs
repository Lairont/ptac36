using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();

            while (true)
            {
                Console.WriteLine("1. Добавить треугольник\n" +
                                  "2. Добавить прямоугольник\n" +
                                  "3. Добавить круг\n" +
                                  "4. Вывести все фигуры\n" +
                                  "5. Выход из программы");

                Console.Write("Введите номер действия: ");
                string input = Console.ReadLine();
                Console.WriteLine();
                switch (input)
                {
                    case "1":
                        shapes.Add(Triangle.Input());
                        break;
                    case "2":
                        shapes.Add(Rectangle.Input());
                        break;
                    case "3":
                        shapes.Add(Circle.Input());
                        break;
                    case "4":
                        OutputShapes(shapes);
                        break;
                    case "5":
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void OutputShapes(List<IShape> shapes)
        {
            foreach (IShape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
