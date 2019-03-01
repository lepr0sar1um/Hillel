using System;

namespace Feb16_Task12
{
public static class Feb16
    {
        static void Main(string[] args)
        {
            const string homeWorkMonth = "February";
            const int homeWorkDate = 16;
 
            Console.WriteLine("Hi! This is my homework for {0} {1}.", homeWorkMonth, homeWorkDate);
            
            var repeat = true;
            while (repeat)
            {
                ShowMenu();
                int selector;
 
                try
                {
                    selector = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    ParseNumbersException();
                    
                    continue;
                }
                             
                switch (selector)
                {
                    case 0:
                        TaskZero();
                        break;
 
                    case 1:
                        TaskOne();
                        break;
 
                    case 2:
                        TaskTwo();
                        break;
 
                    case 3:
                        TaskThree();
                        break;
 
                    case 4:
                        TaskFour();
                        break;
 
                    case 5:
                        TaskFive();
                        break;
 
                    case 6:
                        TaskSix();
                        break;
 
                    case 7:
                        TaskSeven();
                        break;
                   
                    case 8:
                        TaskOneSecondPart();
                        break;
                   
                    case 9:
                        TaskTwoSecondPart();
                        break;
                   
                    case -1:
                        repeat = false;
                        Console.WriteLine("Have a good day!");
                        break;
                       
                }
            }
        }
 
        private static void TaskZero()
        {
            const string firstName = "Ivan", secondName = "Sergeevich", lastName = "Eremenko";
            const byte myAge = 26;
            const long myPhoneNumber = 380937424339;
           
            Console.WriteLine("Hi there! My name is {0} {1} {2}", firstName, secondName, lastName);
            Console.WriteLine("I am {0}, my phone number is {1}", myAge, myPhoneNumber);
            
            WaitForUSer();
        }
       
        private static void TaskOne()
        {
            Console.WriteLine("Pi = " + Math.PI);
            
            WaitForUSer();
        }

        private static void TaskTwo()
        {
            while (true)
            {
                Console.Write("Please, input first number: ");
                if (double.TryParse(Console.ReadLine(), out var firstNumber))
                {
                    Console.Write("Please, input second number: ");
                    if (double.TryParse(Console.ReadLine(), out var secondNumber))
                    {
                        Console.Write("Please, input third number: ");
                        if (double.TryParse(Console.ReadLine(), out var thirdNumber))
                        {
                            Console.WriteLine("OK, let me input two gaps between these numbers: " +
                                              "{0}  {1}  {2}", firstNumber, secondNumber, thirdNumber);

                            WaitForUSer();
                            break;
                        }
                    }
                }
                ParseNumbersException();
            }
        }
 
        private static void TaskThree()
        {
            while (true)
            {
                Console.Write("Please, insert quantity in centimeters: ");
                if (double.TryParse(Console.ReadLine(), out var centiMeters))
                {
                    Console.WriteLine("Total full meters in your number: " + Math.Truncate(centiMeters / 100));
                    
                    WaitForUSer();
                    break;
                }
                ParseNumbersException();
            }
        }
 
        private static void TaskFour()
        {
            const int daysInAWeek = 7;
            while (true)
            {
                Console.Write("Please, input the quantity of days: ");
                if (double.TryParse(Console.ReadLine(), out var days))
                {
                    Console.WriteLine("Total full weeks = " + Math.Truncate(days / daysInAWeek));
                    
                    WaitForUSer();
                    break;
                }
                ParseNumbersException();
            }
        }

        private static void TaskFive()
        {
            while (true)
            {
                Console.Write("Input first value: ");
                if (double.TryParse(Console.ReadLine(), out var firstValue))
                {
                    Console.Write("Input second value: ");
                    if (double.TryParse(Console.ReadLine(), out var secondValue))
                    {
                        Console.WriteLine("Average = " + (firstValue + secondValue) / 2);
                        
                        WaitForUSer();
                        break;
                    }
                }
                ParseNumbersException();
            }
        }

        private static void TaskSix()
        {
            while (true)
            {
                Console.Write("Input your value: ");
                if (double.TryParse(Console.ReadLine(), out var originalNumber))
                {
                    Console.WriteLine("The number in the second degree = " + Math.Pow(originalNumber, 2));
                    
                    WaitForUSer();
                    break;
                }
                ParseNumbersException();
            }
        }

        private static void TaskSeven()
        {
            while (true)
            {
                Console.Write("Please, input side A in mm: ");
                if (double.TryParse(Console.ReadLine(), out var sideA))
                {
                    Console.Write("Please, input side B in mm: ");
                    if (double.TryParse(Console.ReadLine(), out var sideB))
                    {
                        Console.WriteLine("Quantity of squares = " + Math.Truncate(sideA / sideB));
                        
                        WaitForUSer();
                        break;
                    }
                }
                ParseNumbersException();
            }        
        }

        private static void TaskOneSecondPart()
        {
            Console.WriteLine("Machine name: {0}\nOS version: {1}\nUser name: {2}\nProcessor Count: {3}\n",
                Environment.MachineName, Environment.OSVersion, Environment.UserName, Environment.ProcessorCount);
            
            WaitForUSer();
        }
 
        private static void TaskTwoSecondPart()
        {
            while (true)
            {
                Console.Write("Enter number: ");
                if (double.TryParse(Console.ReadLine(), out var number))
                {
                    Console.WriteLine("You have entered {0}", number);
                    
                    WaitForUSer();
                    break;
                }
                ParseNumbersException();
            }
        }
 
        private static void WaitForUSer()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        private static void ParseNumbersException()
        {
            Console.WriteLine("Please, use only numbers!");
            WaitForUSer();
        }

        private static void ShowMenu()
        {
            Console.Clear();
            Console.Write("Task list:\n\n" +
                          "0. Personal data\n" +
                          "1. Show PI\n" +
                          "2. Two gaps between numbers\n" +
                          "3. Convert centimeters into meters\n" +
                          "4. Convert days into weeks\n" +
                          "5. Show average\n" +
                          "6. Calculate sqrt\n" +
                          "7. Show square count\n" +
                          "8. Show system info\n" +
                          "9. Show value from console\n\n" +
                          "Please, select task number between 0 and 9.\n" +
                          "Or -1 to exit: ");
        }
    }
}