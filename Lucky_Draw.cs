using System;

using System;
using System.Collections.Generic;
class Lucky_Draw
{
       
        static int GenerateRandomCoupon(int maxCoupon)
        {
            Random random = new Random();
            return random.Next(1, maxCoupon + 1);
        }

       
        public static int GetTotalRandomNumbers(int n)
        {
            HashSet<int> distinctCoupons = new HashSet<int>();
            int totalRandomNumbers = 0;

            while (distinctCoupons.Count < n)
            {
                int randomCoupon = GenerateRandomCoupon(n);
                totalRandomNumbers++;

                if (!distinctCoupons.Contains(randomCoupon))
                {
                    distinctCoupons.Add(randomCoupon);
                }
            }

            return totalRandomNumbers;
        }
    

   
     public static void lucky_draw()
     { 
            Console.WriteLine("Enter the number of distinct coupon numbers (N): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int totalRandomNumbers = Lucky_Draw.GetTotalRandomNumbers(n);
                Console.WriteLine($"Total random numbers needed to get all distinct coupons: {totalRandomNumbers}");
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer for N.");
            }
     }
}

