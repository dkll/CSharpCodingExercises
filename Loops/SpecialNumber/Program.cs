namespace SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numberToBePrinted = n;
            bool isSpecial = true;
            while (n != 0)
            {
                int lastDigit = n % 10;
                n /= 10;
                if (n % lastDigit != 0)
                {
                    isSpecial = false;
                    break;
                }
            }
            if (isSpecial)
            {
                Console.WriteLine($"{numberToBePrinted} is special");
            }
            else
            {
                Console.WriteLine($"{numberToBePrinted} is not special");
            }

        }
    }
}
