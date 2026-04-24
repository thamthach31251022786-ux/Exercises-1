using System;

class Program {
    static void Main() {
        Console.Write("Enter total days: ");
        int totalDays = Convert.ToInt32(Console.ReadLine());
        
        int years = totalDays / 365;
        int remainingDays = totalDays % 365;
        
        int weeks = remainingDays / 7;
        int days = remainingDays % 7;
        
        Console.WriteLine($"{totalDays} days = {years} years, {weeks} weeks, and {days} days.");
    }
}
