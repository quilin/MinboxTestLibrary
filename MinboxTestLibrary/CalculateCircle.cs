using System;

namespace MinboxTestLibrary
{
    internal class CalculateCircle
    {
        private double GetRadius()
        {
            Console.WriteLine("Введите радиус круга");
            return Check.CheckNumberInput();
        }

        public double CalculateArea()
        {
            var radius = GetRadius();
            return Math.PI * (radius * radius);
        }
    }
}
