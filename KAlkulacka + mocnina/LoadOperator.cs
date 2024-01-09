

namespace KAlkulacka___mocnina
{
    public class OperatorLoader
    {
        public static string LoadOperator()
        {
            string[] validOperators = { "+", "-", "/", "*", "^", "%" };
            string operatorSymbol = "";

            while (!Array.Exists(validOperators, o => o == operatorSymbol))
            {
                Console.Write("Enter symbol(/, +, -, *, ^, %):");
                operatorSymbol = Console.ReadLine();
            }

            return operatorSymbol;

        }
    }
}

