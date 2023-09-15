using System;

class Fibonacci
{
    public static void Fibonacci_Series()
    {
        Console.Write("Enter the number of Fibonacci numbers to generate: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int num1 = 0;
        int num2 = 1;

        Console.Write("Fibonacci Series: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(num1 + " ");
            int result = num1 + num2;
            num1 = num2;
            num2= result;
        }

        Console.WriteLine();
    }
}
