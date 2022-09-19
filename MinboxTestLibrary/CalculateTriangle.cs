using System;

namespace MinboxTestLibrary
{
    class CalculateTriangle
    {
        private double GetSide()
        {
            Console.WriteLine("Введите значение стороны 1");
            return Check.CheckNumberInput();
        }

        public double CalculateArea()
        {
            var side1 = GetSide();
            var side2 = GetSide();
            var side3 = GetSide();
            // TODO: Стороны надо провалидировать! Иначе можно создать треугольник со сторонами (10, 2, 3)

            var halfPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
        }
    }
}
