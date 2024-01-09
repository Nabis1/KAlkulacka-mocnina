

namespace KAlkulacka___mocnina
{
    internal class Calculate
    {
         public static double Calculator(string operation, double number1, double number2)
        {

            double result = 0;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "^":
                    double actualresult = 1;
                    for (int hmtimesmultiply = 0; hmtimesmultiply < (int)number1; hmtimesmultiply++)
                    {
                        actualresult = actualresult * number1;
                    }
                    result = actualresult;
                    break;
                case "%":
                    result = number1 / 100 * number2;
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            return result;
        }
    }
}
