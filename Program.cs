namespace Assignments_2._3._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the tip calculator\n");
            while (true)
            {
                Console.WriteLine("Please enter the bill total!");

                if (!double.TryParse(Console.ReadLine(), out double billTotal))
                {
                    Console.WriteLine("Incorrect input.");
                    continue;
                }
                Console.WriteLine("Please enter the tip percentage:");
                if (!double.TryParse(Console.ReadLine(), out double tipPercentage))
                {
                    Console.WriteLine("Incorrect tip input.");
                    continue;
                }
                TipCalculator.DisplayTotal(billTotal, tipPercentage);
                Console.WriteLine("\nPress enter to leave.");
                Console.ReadKey();
                break;
            }
        }
    }
}
