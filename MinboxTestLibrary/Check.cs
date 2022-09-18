using System;
using System.Collections.Generic;
using System.Text;

namespace MinboxTestLibrary
{
    class Check
    {
        public void CheckNumberInput(out double number)
        {
            bool isNumberEntered = false;
            string userInput = "";

            while (isNumberEntered == false)
            {
                userInput = Console.ReadLine();
                bool success = double.TryParse(userInput, out number);

                if (success == true && number > 0)
                {
                    isNumberEntered = true;
                }
                else
                {
                    Console.WriteLine("Введено не число или введено значения равное 0. Повторите попытку");
                }
            }

            number = double.Parse(userInput);

            Console.WriteLine("Число " + number + " Записано");
        }
    }
}
