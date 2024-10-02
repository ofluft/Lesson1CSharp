namespace Exercise2ArrayCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var strings = new string[10];
            for (int i = 0; i < strings.Length; i++)
                strings[i] = "Элемент" + (i + 1);

            var stringsCopy = new string[strings.Length];
            for (int i = 0; i < strings.Length; i++)
                stringsCopy[i] = strings[i];

            Console.WriteLine("Исходный массив:\n" + string.Join(" ", strings));
            Console.WriteLine("Массив копия:\n" + string.Join(" ", stringsCopy));

        }
    }
}
