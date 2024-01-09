
namespace KAlkulacka___mocnina
{
    public class NumberLoader
    {
        public static double LoadNumber()
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
    }
}
