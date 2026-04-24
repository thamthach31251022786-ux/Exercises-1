using System;

class Program {
    static void Main() {
        Console.Write("Enter the side length of the square: ");
        double side = Convert.ToDouble(Console.ReadLine());
        
        double area = side * side;
        Console.WriteLine($"Area of square = {area}");
    }
}
