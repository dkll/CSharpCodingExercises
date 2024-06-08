namespace SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());
            int currentNumber = int.Parse(Console.ReadLine());
            int previousNumber = 0;

            while (currentNumber != stopNumber)
            {
                previousNumber = currentNumber;
                currentNumber = int.Parse(Console.ReadLine());
            }

            double previousNumberWithBonus = previousNumber * 1.2;

            Console.WriteLine(previousNumberWithBonus);

        }
    }
}
