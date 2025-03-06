using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Name: Muhammad Sohaib Ahmad");
        Console.WriteLine("Roll Number: 24-ST-040");
        
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (b != 0)
        {
            Console.WriteLine($"Quotient: {a / (double)b}");
        }
        else
        {
            Console.WriteLine("Error: Cannot divide by zero.");
    }
}
