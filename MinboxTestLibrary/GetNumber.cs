using System;
using System.Collections.Generic;
using System.Text;

namespace MinboxTestLibrary
{
    class Check
    {
        public void GetNumber(out int number)
        {
            bool isNumberEntered = false;
            string userInput = "";

            while (isNumberEntered == false)
            {
                userInput = Console.ReadLine();
                bool success = int.TryParse(userInput, out number);

                if (success == true)
                {
                    isNumberEntered = true;
                }
                else
                {
                    Console.WriteLine("Введено не число. Повторите попытку");
                }
            }
            number = int.Parse(userInput);
            Console.WriteLine("Число " + number + " Записано");
        }
    }
}
