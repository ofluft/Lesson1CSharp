namespace Exercise5MonthByNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstMonthNumber = 1;
            var lastMontNumber = 12;

            Console.WriteLine("Введите номер месяца:");
            var inputNumber = Convert.ToInt32(Console.ReadLine());

            if (firstMonthNumber <= inputNumber && inputNumber <= lastMontNumber)
                Console.WriteLine((Month)inputNumber);
            else 
                Console.WriteLine("Номер должен быть в диапазоне от 1 до 12 включительно.");
        }

        enum Month
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
    }
}
