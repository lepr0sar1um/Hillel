using System;

namespace Homework_Feb16
{
public static class Feb16
    {
        public static void Main(string[] args)
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
                catch (Exception e)
                {
                    Console.WriteLine("Please, use only numbers.\n" + e.Message);
                    WaitForUSer();
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
 
        public static void TaskZero()
        {
            const string firstName = "Ivan", secondName = "Sergeevich", lastName = "Eremenko";
            const byte myAge = 26;
            const long myPhoneNumber = 380937424339;
           
            Console.WriteLine("Hi there! My name is {0} {1} {2}", firstName, secondName, lastName);
            Console.WriteLine("I am {0}, my phone number is {1}", myAge, myPhoneNumber);
            
            WaitForUSer();
        }
       
        public static void TaskOne()
        {
            Console.WriteLine("Pi = " + Math.PI);
            
            WaitForUSer();
        }
 
        public static void TaskTwo()
        {
            Console.Write("Please, input first number: ");
            var firstNumber = Convert.ToDouble(Console.ReadLine()?.Replace('.', ','));
            
            Console.Write("Please, input second number: ");
            var secondNumber = Convert.ToDouble(Console.ReadLine()?.Replace('.', ','));
            
            Console.Write("Please, input third number: ");
            var thirdNumber = Convert.ToDouble(Console.ReadLine()?.Replace('.', ','));

            Console.WriteLine("OK, let me input two gaps between these numbers: "+
                              "{0}  {1}  {2}", firstNumber, secondNumber, thirdNumber);
            
            WaitForUSer();
        }
 
        public static void TaskThree()
        {
            Console.Write("Please, insert quantity in centimeters: ");
            var centiMeters = Convert.ToDouble(Console.ReadLine()?.Replace('.', ','));
           
            Console.WriteLine("Total meters in your number: " + (centiMeters / 100));
            
            WaitForUSer();
        }
 
        public static void TaskFour()
        {
            Console.Write("Please, input the quantity of days: ");
            var days = Convert.ToDouble(Console.ReadLine()?.Replace('.', ','));
            const int daysInAWeek = 7;
            Console.WriteLine("Full weeks = " + (days/daysInAWeek));
            
            WaitForUSer();
        }
 
        public static void TaskFive()
        {
            Console.Write("Input first value: ");
            var firstValue = Convert.ToDouble(Console.ReadLine()?.Replace('.', ','));
           
            Console.Write("Input second value: ");
            var secondValue = Convert.ToDouble(Console.ReadLine()?.Replace('.', ','));
           
            Console.WriteLine("Average = " + (firstValue + secondValue)/2);
            
            WaitForUSer();
        }
 
        public static void TaskSix()
        {
            Console.Write("Input your value: ");
            var introducedValue = Convert.ToDouble(Console.ReadLine()?.Replace('.', ','));
           
            Console.WriteLine("The square root of the value entered = " + Math.Sqrt(introducedValue));
            
            WaitForUSer();
        }
 
        public static void TaskSeven()
        {
            Console.Write("Please, input side A in mm: ");
            var sideA = Convert.ToDouble(Console.ReadLine()?.Replace('.', ','));
            
            Console.Write("Please, input side B in mm: ");
            var sideB = Convert.ToDouble(Console.ReadLine()?.Replace('.', ','));
           
            Console.WriteLine("The are {0} squares", sideA / sideB);
            
            WaitForUSer();
        }
 
        public static void TaskOneSecondPart()
        {
            Console.WriteLine("Machine name: {0}\nOS version: {1}\nUser name: {2}\nProcessor Count: {3}\n",
                Environment.MachineName, Environment.OSVersion, Environment.UserName, Environment.ProcessorCount);
            
            WaitForUSer();
        }
 
        public static void TaskTwoSecondPart()
        {
            Console.Write("Enter number: ");
            var number = Convert.ToDouble(Console.ReadLine()?.Replace('.', ','));
            Console.WriteLine("You have entered {0}", number);
           
            WaitForUSer();
        }
 
        public static void WaitForUSer()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        public static void ShowMenu()
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