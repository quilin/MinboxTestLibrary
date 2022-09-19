using System;
using System.Collections.Generic;
using System.Text;

namespace MinboxTestLibrary
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            CalculateCircle calculateCircle = new CalculateCircle();
            CalculateTriangle calculateTriangle = new CalculateTriangle();

            double cirlceArea;
            double triangleArea;

            bool isWorking = true;
            Console.WriteLine("1 - высчитать площадь круга\n2 - высчитать площадь треугольника\n3 - выход");

            while (isWorking)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        calculateCircle.CalculateArea(out cirlceArea);
                        break;
                    case "2":
                        calculateTriangle.CalculateArea(out triangleArea);
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
