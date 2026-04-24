using System;

class Program {
    static void Main() {
        int a = 5, b = 10, temp;
        Console.WriteLine($"Before swap: a = {a}, b = {b}");
        
        // Swapping
        temp = a;
        a = b;
        b = temp;
        
        Console.WriteLine($"After swap: a = {a}, b = {b}");
    }
}
