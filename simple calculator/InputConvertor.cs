using System;

namespace simple_calculator
{
    public class InputConverter
    {
        public double ConvertInputToNumber(string argTextInput)
        {
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber))
            {
                throw new ArgumentException("Excpected a numeric value");
            }

            return convertedNumber;
        }
    }
}