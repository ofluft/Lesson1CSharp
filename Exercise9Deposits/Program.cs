using System.Reflection.Metadata;

namespace Exercise9Deposits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите размер вклада (рублей):");
            var startDeposit = 0;
            if (!int.TryParse(Console.ReadLine(), out startDeposit))
            {
                Console.WriteLine("Введено некорректное значение");
                return;
            }

            Console.WriteLine("Укажите срок вклада (количество месяцев):");
            var depositTerm = 0;
            if (!int.TryParse(Console.ReadLine(), out depositTerm))
            {
                Console.WriteLine("Введено некорректное значение");
                return;
            }

            Console.WriteLine("Расчет по вкладу:");
            int monthCounter = 1;
            CalculateGrowth(startDeposit, monthCounter, depositTerm);

        }

        private static void CalculateGrowth(double deposit, int monthCount, int totalTerm)
        {
            if (monthCount > totalTerm)
            {
                return;
            }

            var depositOfTheMonth = Math.Round((double) deposit * 1.02, 4);
            var growthAmount = Math.Round(depositOfTheMonth - deposit, 4);
            Console.WriteLine("{0} месяц:\nСумма: {1}\nПрирост за месяц: {2}\n", monthCount, depositOfTheMonth, growthAmount);           

            monthCount++;

            CalculateGrowth(depositOfTheMonth, monthCount, totalTerm);

        }

    }
}
