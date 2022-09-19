using System;

namespace MinboxTestLibrary
{
    internal class Check
    {
        public static double CheckNumberInput()
        {
            do
            {
                var input = Console.ReadLine();
                if (double.TryParse(input, out var number) && number > 0)
                {
                    return number;
                }

                Console.WriteLine("Введено не число или введено значения равное 0. Повторите попытку");
            } while (true);
        }
    }
}
