using System;
using System.Collections.Generic;
using System.Text;
using MinboxTestLibrary;

namespace MinboxTestLibrary
{
    class CalculateTriangle
    {
        private Check _check = new Check();

        private void GetSides(out double sideOne, out double sideTwo, out double sideThree)
        {
            Console.WriteLine("Введите значение стороны 1");

            _check.CheckNumberInput(out sideOne);

            Console.WriteLine("Введите значение стороны 2");

            _check.CheckNumberInput(out sideTwo);

            Console.WriteLine("Введите значение стороны 3");

            _check.CheckNumberInput(out sideThree);
        }

        public void CalculateArea(out double area)
        {
            double sideOne;
            double sideTwo;
            double sideThree;

            GetSides(out sideOne, out sideTwo, out sideThree);

            double halfPerimetr = (sideOne + sideTwo + sideThree) / 2;

            area = Convert.ToDouble(Math.Sqrt(halfPerimetr * (halfPerimetr - sideOne) * (halfPerimetr - sideTwo) * (halfPerimetr - sideThree)));
        }
    }
}
