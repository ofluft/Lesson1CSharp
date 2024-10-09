namespace Exercise1Quotient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            var a = 0;
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Введено некорректное значение");
                return;
            }

            Console.WriteLine("Введите второе число:");
            var b = 0;
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Введено некорректное значение");
                return;
            }

            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
                return;
            }

            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine("Результат:\n{0}/ {1} = {2}. Остаток = {3}", a, b, quotient, remainder);

        }
    }
}
