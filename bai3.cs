using System;

class Program {
    static void Main() {
        Console.Write("Enter first floating-point number: ");
        float num1 = float.Parse(Console.ReadLine());
        
        Console.Write("Enter second floating-point number: ");
        float num2 = float.Parse(Console.ReadLine());
        
        float product = num1 * num2;
        Console.WriteLine($"Product = {product}");
    }
}
