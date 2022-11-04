using System;

namespace MyApp.MathsService
{
    public class Calculator
    {
        public bool IsEven(int number)
        {
            if(number < 0)
            {
                throw new ArgumentException($"Argument {number} is less than zero."); 
            }

            return (number % 2) == 0;
        }
    }
}