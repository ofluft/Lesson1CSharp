namespace Exercise1Quotient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            var b = Convert.ToInt32(Console.ReadLine());

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
