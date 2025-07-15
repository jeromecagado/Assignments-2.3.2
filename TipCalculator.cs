using System;


namespace Assignments_2._3._2
{
    public static class TipCalculator
    {
        public static void DisplayTotal(double bill, double tipAmount)
        {
            double tipPercentage = tipAmount / 100.0;
            double tip = bill * tipPercentage;
            double billTotal = tip + bill;

            Console.WriteLine($"Bill: {bill:C}");
            Console.WriteLine($"Tip: {tipPercentage.ToString("P0")}  == {tip:C}");
            Console.WriteLine($"Total Bill: {billTotal:C}");
        }
    }
}
