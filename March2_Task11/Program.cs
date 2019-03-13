using System;

namespace March2_Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            var step = 0;
            var finalDirection = string.Empty;

            while (true)
            {
                Console.Clear();
                
                Console.WriteLine("Please, select start direction, " +
                                  "where N = North, W = West, S = South and E = East");
                var direction = Console.ReadKey().KeyChar;
                Console.ReadLine();

                if (!(direction.Equals('w') || direction.Equals('e') ||
                    direction.Equals('s') || direction.Equals('n')))
                {
                    Console.WriteLine("Please, use w, e, n, s only!\n" +
                                      "Press any key to continue...");
                    Console.ReadLine();
                    continue;
                }
                
                while (step > -2 && step < 2)
                {

                    Console.WriteLine("Please, input digital command for the Robot, " +
                                      "like -1 to move right, " +
                                      "1 to move left, " +
                                      "0 to move forward\n" +
                                      "or any another digit to exit");

                    try
                    {
                        step = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You have entered incorrect command!\n" +
                                          "Press any key to continue...");
                        Console.ReadLine();
                        continue;
                    }

                    if (step == -1)
                    {
                        switch (direction)
                        {
                            case 'N':
                                direction = 'E';
                                break;
                            case 'W':
                                direction = 'N';
                                break;
                            case 'S':
                                direction = 'W';
                                break;
                            case 'E':
                                direction = 'S';
                                break;
                        }
                    }

                    if (step == 1)
                    {
                        switch (direction)
                        {
                            case 'N':
                                direction = 'W';
                                break;
                            case 'W':
                                direction = 'S';
                                break;
                            case 'S':
                                direction = 'E';
                                break;
                            case 'E':
                                direction = 'N';
                                break;
                        }
                    }
                    
                    finalDirection += direction;
                }
                break;
            }
            Console.WriteLine($"Your direction is: {finalDirection}\n" +
                              $"Press any key to exit...");
            Console.ReadLine();
        }
    }
}


