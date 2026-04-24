using System;

class Program {
    static void Main() {
        Console.Write("Enter a character: ");
        char c = Console.ReadKey().KeyChar; 
        Console.WriteLine(); 
        int asciiValue = (int)c;
        Console.WriteLine($"ASCII Value of '{c}' is {asciiValue}");
    }
}
