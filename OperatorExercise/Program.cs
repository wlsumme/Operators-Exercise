namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int quotent = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotent} remainder {remainder}");
            Console.WriteLine("What is the radious of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");


        }

        public static double AreaOfCircle(double radius)
        {

            return Math.PI * Math.Pow(radius, 2);
        }


    }
}       // K = 16