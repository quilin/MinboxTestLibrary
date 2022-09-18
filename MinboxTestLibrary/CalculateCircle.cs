using System;
using System.Collections.Generic;
using System.Text;

namespace MinboxTestLibrary
{
    class CalculateCircle
    {
        private Check _check = new Check();

        private void GetRadius(out double radius)
        {
            Console.WriteLine("Введите радиус круга");

            _check.CheckNumberInput(out radius);
        }

        public void CalculateArea(out double area)
        {
            double radius;
            const double Constant = 3.14;

            GetRadius(out radius);

            area = Constant * (radius * radius);
        }
    }
}
