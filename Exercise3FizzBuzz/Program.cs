using System.Text;

namespace Exercise3FizzBuzz
{
    internal class Program
    {
        private const int maxNumber = 101;
        static void Main(string[] args)
        {
            for (int i = 1; i < maxNumber; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                    Console.Write("FizzBuzz ");
                else if (i % 3 == 0)
                    Console.Write("Fizz ");
                else if (i % 5 == 0)
                    Console.Write("Buzz ");
                else 
                    Console.Write(i + " ");
            }
        }
    }
}
