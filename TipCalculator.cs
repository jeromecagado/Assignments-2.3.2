using System;


namespace Assignments_2._3._2
{
    public static class TipCalculator
    {
        public static void DisplayTotal(double bill, double tipPercentage)
        {
            double tip = bill * (tipPercentage/100);
            double billTotal = tip + bill;
            Console.WriteLine($"Bill: {bill:C}");
            Console.WriteLine($"Tip: {tipPercentage}%  == {tip:C}");
            Console.WriteLine($"Total Bill: {billTotal:C}");
        }
    }
}
