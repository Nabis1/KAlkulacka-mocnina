using KAlkulacka___mocnina;
using System;
using System.Data;

namespace MyFirstProgram
{
    class Program
    {
        static void Main()
        {
            {
                
                double number1 = NumberLoader.LoadNumber();
                double number2 = NumberLoader.LoadNumber();
                string operation = OperatorLoader.LoadOperator();
                double result = Calculate.Calculator(operation, number1, number2);
                Console.WriteLine($" Result is  {number1} {operation} {number2} = {result}");
            }
            
        

        }
    }
}
