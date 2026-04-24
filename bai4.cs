using System;

class Program {
    static void Main() {
        Console.Write("Enter length in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        
        double meters = feet * 0.3048;
        Console.WriteLine($"{feet} feet = {meters} meters");
    }
}
