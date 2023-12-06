using System;
using System.Data;

namespace MyFirstProgram
{
    class Program
    {
        static void Main()
        {
            {
                double number1 = LoadNumber();
                double number2 = LoadNumber();
                string operation = LoadOperator();
                double result = Calculate(operation, number1, number2);
                Console.WriteLine($" Vysledek je {number1} {operation} {number2} = {result}");
            }
        }
        static double LoadNumber()
         {
            
            bool isNumberValid = false;
            double result = 0;  
            while (isNumberValid is false)
            {
                Console.Write("Enter number:");
                string symbol = Console.ReadLine();
                bool successconvert = double.TryParse(symbol, out result);
                string usermsg;

                if (successconvert)
                {
                    isNumberValid = true;
                    usermsg = "Great!";
                }
                else
                {
                    isNumberValid = false;
                    usermsg = "Wrong number, try again!";
                }
                Console.WriteLine(usermsg);
             }
         return result;
         }   

              static string LoadOperator()
            {
                string symbol = "";
                while (symbol is not ("+" or "-" or "/" or "*" or "^" or "%"))
                {
                    Console.Write("Enter symbol(/,+,-,*,^,%):");
                    symbol = Console.ReadLine();
                }
              return symbol;
            }
              static double Calculate(string operation, double number1, double number2)
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
        /// Uzivatelsky Vstup - Cisla
        /// 1. Presun logiku nacitani cisla uzivatele do samostatnych metod. Kazdy vstup vytvor jako samostatnou funkci.
        /// 2. Vsimnes si, ze obe nove vznikle metody jsou prakticky stejne, krome malych odlisnosti (vypis do konzole pro uzivatele)
        /// 
        /// 3. Vytvor treti metodu, ktera dane odlisnosti bude rozlisovat pomoci parametru metody, a zbav se obou predchozich metod.
        /// Prvni volani metody vypise uzivateli ze po nem chceme prvni cislo
        /// Druhy volani metody vypise uzivateli ze po nem chceme druhe cislo
        /// 
        /// Uzivatelsky Vstup - Operator
        /// 1. Presun logiku nacitani operatoru do samostatne metody.
    }
}
