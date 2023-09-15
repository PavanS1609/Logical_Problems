using System;
class Perfect_Number
{
    static bool IsPerfectNumber(int num)
    {
        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }
        return sum == num;
    }
    public static void PerfectNumber()
    {
        Console.Write("Enter a number to check if it's a perfect number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPerfectNumber(number))
        {
            Console.WriteLine(number + " is a perfect number.");
        }
        else
        {
            Console.WriteLine(number + " is not a perfect number.");
        }
    }
}

