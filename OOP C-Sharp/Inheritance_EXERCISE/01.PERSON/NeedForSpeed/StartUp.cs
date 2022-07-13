namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var sportCar = new SportCar(10, 10);
            sportCar.Drive(1);
            System.Console.WriteLine();
        }
    }
}
