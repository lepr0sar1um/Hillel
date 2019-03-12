using System;

namespace March2_Task2
{
    public class Input
    {
        public void InputValues()
        {
            var unit = new Units();
            var decade = new Decade();
            while (true)
            {
                Console.Clear();
                                
                Console.Write("Input value: ");
                var value = (Console.ReadLine());

                if (value?.Length == 2 && (int.TryParse(value, out var newValue)))
                {
                    unit.FindUnits(newValue);
                    decade.FindDecade(newValue);
                    break;
                }
                Console.WriteLine("Please, input only 2 digits");
                Console.ReadLine();
            }
        }
    }
}