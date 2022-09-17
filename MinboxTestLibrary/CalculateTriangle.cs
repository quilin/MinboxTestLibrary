using System;
using System.Collections.Generic;
using System.Text;
using MinboxTestLibrary;

namespace MinboxTestLibrary
{
    class CalculateTriangle
    {
        Check check = new Check();

        public CalculateTriangle()
        {
        
        }

        private void GetSides(out int sideOne, out int sideTwo, out int sideThree)
        {
            Console.WriteLine("Введите значение стороны 1");

            check.GetNumber(out sideOne);

            Console.WriteLine("Введите значение стороны 2");

            check.GetNumber(out sideTwo);

            Console.WriteLine("Введите значение стороны 3");

            check.GetNumber(out sideThree);
        }

        private void CalculateTriangleArea()
        {
            int sideOne;
            int sideTwo;
            int sideThree;

            GetSides(out sideOne, out sideTwo, out sideThree);

            int halfPerimetr = (sideOne + sideTwo + sideThree) / 2;
            int area = Convert.ToInt32(Math.Sqrt(halfPerimetr * (halfPerimetr - sideOne) * (halfPerimetr - sideTwo) * (halfPerimetr - sideThree)));
        }
    }
}
