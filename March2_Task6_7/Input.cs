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
            
                for (var i = 0; i < inputValues?.Length; i++)
                {
                    var isNumber = int.TryParse(inputValues[i], out var number);
                
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
            
            process.FindCounter(valuesArray);
        }
    }
}