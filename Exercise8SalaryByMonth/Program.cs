namespace Exercise8SalaryByMonth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rowCount = 7;
            var columnCount = 12;
            var salaryMatrix = new int[rowCount, columnCount];
            Random random = new Random();
            for (int i = 0; i < rowCount; i++) 
            {
                for (int j = 0; j < columnCount; j++)
                {
                    salaryMatrix[i, j] = random.Next(10_000, 25_000);
                }
            }

            Console.WriteLine("Введите номер месяца (от 1 до 12 включительно) для расчета зарплаты:");
            var monthNumber = Convert.ToInt32(Console.ReadLine());

            var sumSalary = 0;
            var monthColumn = monthNumber - 1;
            for (int i = 0; i < rowCount; i++)    
                  sumSalary += salaryMatrix[i, monthColumn];

            Console.WriteLine($"Суммарная зарплата в {monthNumber} месяце - {sumSalary} рублей.");

        }
    }
}
