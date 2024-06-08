namespace TriangleOfStars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                    
                }

                Console.WriteLine();
            }

        }
    }
}
