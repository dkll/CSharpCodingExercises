namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            decimal Balance = 0;
            while (input != "End")
            {
                decimal currentChange = decimal.Parse(input);
                Balance += currentChange;
                if (currentChange > 0)
                {
                    Console.WriteLine($"Increase: {currentChange:F2}");
                }
                else
                {
                    Console.WriteLine($"Decrease: {-currentChange:F2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Balance: {Balance:F2}");

        }
    }
}
