namespace March2_Task5
{
    public class Logic
    {
        public double ProcessValue(double value)
        {
            if (value > 0)
            {
                return value + 1;
            }
            if (value < 0)
            {
                return value - 2;
            }
            if (value.Equals(0))
            {
                return value = 10;
            }
            return value;
        }
    }
} 