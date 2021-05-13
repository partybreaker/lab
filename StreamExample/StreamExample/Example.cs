namespace StreamExample
{
    public class Example
    {
        public int GetSomeValue(int a, int b)
        {
            return a > b ? a : b;
        }

        public int GetSomeValue(params int[] args)
        {
            int result = args[0];
            for(int i = 0; i < args.Length; i++)
            {
                if (result < args[i])
                {
                    result = args[i];
                }
            }

            return result;
        }
    }
}