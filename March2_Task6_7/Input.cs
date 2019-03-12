using System;

namespace March2_Task6
{
    public class Input
    {
        public void InputValues()
        {
            var process = new Logic();
            var valuesArray = new int[3];

            var isActive = true;
            while (isActive)
            {
                Console.Clear();
                
                Console.Write("Enter three integers separated by a space: ");
                var inputValues = Console.ReadLine()?.Split(new[] { ' ', '\n', '\t', '.', ',' }, 
                    StringSplitOptions.RemoveEmptyEntries);
            
                for (int i = 0; i < inputValues?.Length; i++)
                {
                    int number;
                    var isNumber = int.TryParse(inputValues[i], out number);
                
                    if(isNumber) 
                    {
                        valuesArray[i] = number;
                        isActive = false;
                    }
                    else
                    {
                        Console.WriteLine("Please, input only numbers!");
                        Console.ReadLine();
                        break;
                    }
                }
            }
                                
            Console.Write("You have entered: ");
            foreach (var element in valuesArray)
            {
                Console.Write("{0} ", element);
            }
            
            process.FindCounter(valuesArray);
        }
    }
}