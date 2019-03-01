namespace Feb23_Task2
{
    public class OddPercent
    {
        public float OddPerc(long inputValue)
        {
            float odd = 0;
            var i = 0;
            do
            {
                if ((inputValue % 10) % 2 != 0)
                    odd++;

                inputValue /= 10;
                i++;

            } while (inputValue > 0);

            var oddPercent = odd * 100 / i;
            return oddPercent;
        }
    }
}