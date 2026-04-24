using System;

class Program {
    static void Main() {
        // Celsius to Fahrenheit
        Console.Write("Enter temperature in Celsius: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double f = (c * 9.0 / 5.0) + 32.0;
        Console.WriteLine($"{c} Celsius = {f} Fahrenheit");
        
        // Fahrenheit to Celsius
        Console.Write("\nEnter temperature in Fahrenheit: ");
        f = Convert.ToDouble(Console.ReadLine());
        c = (f - 32.0) * 5.0 / 9.0;
        Console.WriteLine($"{f} Fahrenheit = {c} Celsius");
    }
}
