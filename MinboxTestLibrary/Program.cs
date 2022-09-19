using System;

namespace MinboxTestLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var isWorking = true;
            Console.WriteLine("1 - высчитать площадь круга\n2 - высчитать площадь треугольника\n3 - выход");

            while (isWorking)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        var calculateCircle = new CalculateCircle();
                        var circleArea = calculateCircle.CalculateArea();
                        Console.WriteLine($"Площадь круга {circleArea}");
                        break;
                    case "2":
                        var calculateTriangle = new CalculateTriangle();
                        var triangleArea = calculateTriangle.CalculateArea();
                        Console.WriteLine($"Площадь треугольника {triangleArea}");
                        break;
                    case "3":
                        isWorking = false;
                        break;
                    default:
                        Console.WriteLine("Неверная команда");
                        break;
                }
            }
        }
    }
}
