namespace Feb23_Task2
{
    public class EvenPercent
    {
        public float EvenPerc(long inputValue)
        {
            float even = 0;
            var i = 0;
            do
            {
                if ((inputValue % 10) % 2 == 0)
                    even++;

                inputValue /= 10;
                i++;
            } while (inputValue > 0);

            var evenPercent = even * 100 / i;
            return evenPercent;
        }
    }
}