namespace CalculationConsole
{
    public static class Operation
    {
        public static int SumTwoInt(int value1, int value2)
        {
            if(value1 < 0 || value2 < 0 )
                throw new InvalidOperationException("O valor não pode ser menor que zero.");
            return value1 + value2;
        }
        
        public static int SumArrayInt(int[] value)
        {
            int res = 0;
            foreach (var i in value)
            {
                if (i < 0)
                {
                    throw new InvalidOperationException("O valor não pode ser menor que zero.");
                }
                res += i;
            }

            return res;
        }
    }
}