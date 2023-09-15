using System;

class ReverseNumber
{
    static int Reverse(int num)
    {
        int reversedNum = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reversedNum = reversedNum * 10 + digit;
            num /= 10;
        }

        return reversedNum;
    }
    public static void Reverse()
    {
        Console.Write("Enter a number to reverse: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = Reverse(number);

        Console.WriteLine("Reversed number: " + reversedNumber);
    }
}

