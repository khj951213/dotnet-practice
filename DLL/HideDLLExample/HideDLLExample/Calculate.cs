namespace HideDLLExample
{
    public static class Calculate
    {
        public static int Addition(int a, int b) => a + b;
        public static int Subtraction(int a, int b) => a - b;
        public static int Multiplication(int a, int b) => a * b;
        public static int Division(int a, int b) => a / b;
        public static int Remainder(int a, int b) => a % b;
        public static int Pow(int a, int b)
        {
            var r = 0;
            for (int i = 0; i <  b; i++) 
            {
                r *= a;
            }
            return r;
        }
    }
}