namespace DivisionChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int canBeDividedBy2Counter = 0;
            int canBeDividedBy3Counter = 0;
            int canBeDividedBy4Counter = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if(currentNumber %2 == 0)
                {
                    canBeDividedBy2Counter++;
                }
                if(currentNumber %3 == 0) 
                { 
                    canBeDividedBy3Counter++;
                }
                if (currentNumber %4 == 0)
                {
                    canBeDividedBy4Counter++;
                }

            }

            double canBeDividedBy2Percentage = (double)canBeDividedBy2Counter/n * 100;
            double canBeDividedBy3Percentage = (double)canBeDividedBy3Counter/n * 100;
            double canBeDividedBy4Percentage = (double)canBeDividedBy4Counter/n * 100;

            Console.WriteLine($"{canBeDividedBy2Percentage:F2}%");
            Console.WriteLine($"{canBeDividedBy3Percentage:F2}%");
            Console.WriteLine($"{canBeDividedBy4Percentage:F2}%");
        }
    }
}
