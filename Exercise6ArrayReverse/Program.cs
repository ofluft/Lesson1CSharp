
namespace Exercise6ArrayReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите желаемую длину массива:");
            var arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] numbers = GenerateNumbers(arrayLength);
            
            Console.WriteLine("Изначальный порядок");
            PrintNumbers(numbers);
            Console.WriteLine();

            Reverse(numbers);

            Console.WriteLine("Обратный порядок");
            PrintNumbers(numbers);

        }

        private static void PrintNumbers(int[] numbers)
        {
            foreach (var number in numbers)  
                Console.Write(number + " ");
        }

        private static void Reverse(int[] numbers)
        {
            var arrayLength = numbers.Length;
            var temp = 0;
            for (int i = 0; i < arrayLength/ 2; i++) 
            {
                temp = numbers[i];
                numbers[i] = numbers[arrayLength - i - 1];
                numbers[arrayLength - i - 1] = temp;
            }
        }

        private static int[] GenerateNumbers(int length)
        {
            var numbers = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
                numbers[i] = random.Next(0, 101);

            return numbers;
        }
    }
}
