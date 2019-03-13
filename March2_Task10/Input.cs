using System;

namespace March2_Task10
{
    public class Input
    {
        public void SelectItem()
        {
            var repeat = true;
            while (repeat)
            {
                ShowMenu();
                int selector;
                double multiplier;
                
                try
                {
                    selector = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);                    
                    continue;
                }
                             
                switch (selector)
                {
                    case 1:
                        multiplier = 0.1;
                        InputValue(multiplier);
                        break;
 
                    case 2:
                        multiplier = 1000;
                        InputValue(multiplier);
                        break;
 
                    case 3:
                        multiplier = 1;
                        InputValue(multiplier);
                        break;
 
                    case 4:
                        multiplier = 0.001;
                        InputValue(multiplier);
                        break;
 
                    case 5:
                        multiplier = 0.01;
                        InputValue(multiplier);
                        break;
                   
                    case -1:
                        repeat = false;
                        Console.WriteLine("Have a good day!");
                        break;
                }
            }
        }

        private void InputValue(double multiplier)
        {
            var process = new Logic();
            while (true)
            {
                Console.Clear();

                Console.Write("Please, input quantity: ");
                if (double.TryParse(Console.ReadLine(), out var value))
                {
                    process.ProcessValue(value, multiplier);
                    break;
                }
                Console.WriteLine("Please, use only numbers!");
                Console.ReadLine();
            }
        }
        
        private void ShowMenu()
        {
            Console.Clear();
            
            Console.Write("Item list:\n\n" +
                          "1. Decimeter\n" +
                          "2. Kilometer\n" +
                          "3. Meter\n" +
                          "4. Millimeter\n" +
                          "5. Centimeter\n" +
                          "Please, select task number between 1 and 5.\n" +
                          "Or -1 to exit: ");
        }
    }
}