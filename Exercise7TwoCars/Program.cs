namespace Exercise7TwoCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скорость первого автомобиля (км/ч):");
            var firstCarSpeed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите скорость второго автомобиля (км/ч):");
            var secondCarSpeed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите расстояние отрыва первого автомобиля от второго (км):");
            var distance = Convert.ToInt32(Console.ReadLine());

            var timeToDistance = 0.5;
            var firstCarDistanceInTime = firstCarSpeed * timeToDistance + distance;
            var secondCarDistanceInTime = secondCarSpeed * timeToDistance;

            var distanceDifference = Math.Abs(firstCarDistanceInTime - secondCarDistanceInTime);

            if (firstCarDistanceInTime > secondCarDistanceInTime)
                Console.WriteLine($"Первый автомобиль опережает второй на {distanceDifference} км.");
            else if (firstCarDistanceInTime < secondCarDistanceInTime)
                Console.WriteLine($"Второй автомобиль опережает первый на {distanceDifference} км.");
            else 
                Console.WriteLine("Автомобили едут вровень");

        }
    }
}
