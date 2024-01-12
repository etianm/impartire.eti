using System;

class Program
{
    static void Main()
    {
        int a, b;
        Console.Write("Enter a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        b = Convert.ToInt32(Console.ReadLine());

        if (a % b != 0)
        {
            Console.WriteLine("Impartirea nu poate fi efectuata in mod exact.");
        }
        else
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
    }
}


