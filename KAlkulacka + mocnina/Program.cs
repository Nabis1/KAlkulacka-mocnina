using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("    c a l c u l a t o r ");
                Console.WriteLine("     << - - - - - - - >> ");
                {
                    bool isNumberValid = false;
                    double number1 = 0;
                    while (isNumberValid == false)
                    {
                        Console.Write("Enter first number:");

                        bool povedloSePrevest = double.TryParse(Console.ReadLine(), out number1);
                        string vzkazProUzivatele;

                        if (povedloSePrevest)
                        {
                            isNumberValid = true;
                            vzkazProUzivatele = "Great!";
                        }
                        else
                        {
                            isNumberValid = false;
                            vzkazProUzivatele = "Wrong number, try again!";
                        }
                        Console.WriteLine($"Podarilo se prevest: {vzkazProUzivatele}, Prvni cislo je: {number1}");
                    }

                    bool isnumber2Valid = false;
                    double number2 = 0;
                    while (isnumber2Valid == false)
                    {
                        Console.Write("Enter second number:");

                        bool povedloSePrevest = double.TryParse(Console.ReadLine(), out number2);
                        string vzkazProUzivatele;

                        if (povedloSePrevest)
                        {
                            isnumber2Valid = true;
                            vzkazProUzivatele = "Great!";
                        }
                        else
                        {
                            isnumber2Valid = false;
                            vzkazProUzivatele = "Wrong number, try again!";
                        }
                        Console.WriteLine($"Podarilo se prevest: {vzkazProUzivatele}, Prvni cislo je: {number2}");
                    }

                    string symbol = "";
                    while (symbol != "+" && symbol != "-" && symbol != "/" && symbol != "*" && symbol != "^" && symbol != "%" )
                    {
                        Console.Write("Enter symbol(/,+,-,*,^,%):");
                        symbol = Console.ReadLine();
                    }

                    double result = 0;
                    switch (symbol)
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
                            double aktualniVysledek = 1;
                            for (int kolikratsemnasobil = 0; kolikratsemnasobil < (int)number2; kolikratsemnasobil++ )
                            {
                                aktualniVysledek = aktualniVysledek * number1;
                            }
                            result = aktualniVysledek;
                            break;
                        case "%":
                            result = number1 / 100 * number2;
                            break;
                        
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                        
                    }
                    Console.WriteLine($" Vysledek je {number1} {symbol} {number2} = {result}");
                }    
            }
        }
    }
}
