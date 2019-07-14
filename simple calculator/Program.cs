using System;

namespace simple_calculator
{
    public class Program
    {
        public static void Main(string[] args)
        { 
//            starting to learn projects in c# 
//            Author@ Anthony Amoah
//            simple calculator app 
            try
            {
             var inputConverter = new InputConverter();
             var calculatorEngine = new CalculatorEngine();
              var firstNumber = inputConverter.ConvertInputToNumber(Console.ReadLine());
              var secondNumber = inputConverter.ConvertInputToNumber(Console.ReadLine());
              var operation = Console.ReadLine();
              var results = calculatorEngine.calculate(operation, firstNumber, secondNumber);
               Console.WriteLine(results);
            }
            catch (Exception e)
            {
//                Start logging exceptions
                Console.WriteLine(e.Message);
            }
            
        }
    }
}