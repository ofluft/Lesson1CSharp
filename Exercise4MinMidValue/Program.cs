namespace Exercise4MinMidValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = random.Next(1, 101);

            var sum = 0;
            var minValue = numbers[0];
            foreach (var i in numbers)
            {
                sum += i;
                if (minValue > i)
                    minValue = i;
            }
            Console.WriteLine("Массив значений: " + string.Join(" ", numbers)); 
            Console.WriteLine("Минимальное значение в массиве: {0}\nСреднее арифметическое значение в массиве: {1}", minValue, sum/ numbers.Length);
            
        }
    }
}
