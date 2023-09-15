using System;
using System;

 class Stop_Watch
 {
      public  static void stop_Watch() 
      {
            Console.WriteLine("Stopwatch Program");

            while (true)
            {
                Console.WriteLine("Press 'S' to start the stopwatch or 'Q' to quit: ");
                var choice = Console.ReadKey(intercept: true).Key;

                if (choice == ConsoleKey.S)
                {
                    double elapsedMilliseconds = MeasureElapsedTime();
                    Console.WriteLine($"Elapsed Time: {elapsedMilliseconds / 1000:F2} seconds");
                }
                else if (choice == ConsoleKey.Q)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'S' to start or 'Q' to quit.");
                }
            }
        }

        static double MeasureElapsedTime()
        {
            Console.WriteLine("Press Enter to start the stopwatch...");
            Console.ReadLine(); // Wait for Enter key
            DateTime startTime = DateTime.Now;

            Console.WriteLine("Press Enter again to stop the stopwatch...");
            Console.ReadLine(); // Wait for Enter key
            DateTime endTime = DateTime.Now;

            TimeSpan elapsed = endTime - startTime;
            return elapsed.TotalMilliseconds;
        }
 }
 
