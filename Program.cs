namespace Static_Mangum_Stephen
{
    using System;

    public static class Calculate
    {
        public static float result;

        // Static constructor!!
        static Calculate()
        {
            result = 0.0f;
        }

        // Integer methods!!
        public static float Add(int a, int b)
        {
            result = a + b;
            return result;
        }

        public static float Subtract(int a, int b)
        {
            result = a - b;
            return result;
        }

        public static float Multiply(int a, int b)
        {
            result = a * b;
            return result;
        }

        public static float Divide(int a, int b)
        {
            if (b != 0)
                result = (float)a / b;
            else
                result = 0.0f; // Or throw an exception...yeah
            return result;
        }

        // Float overloads!!
        public static float Add(float a, float b)
        {
            result = a + b;
            return result;
        }

        public static float Subtract(float a, float b)
        {
            result = a - b;
            return result;
        }

        public static float Multiply(float a, float b)
        {
            result = a * b;
            return result;
        }

        public static float Divide(float a, float b)
        {
            if (b != 0.0f)
                result = a / b;
            else
                result = 0.0f; // Or throw an exception...again
            return result;
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            // Integer calls!!
            Console.WriteLine("Integer Operations:");
            Console.WriteLine("Add: " + Calculate.Add(10, 5));
            Console.WriteLine("Subtract: " + Calculate.Subtract(10, 5));
            Console.WriteLine("Multiply: " + Calculate.Multiply(10, 5));
            Console.WriteLine("Divide: " + Calculate.Divide(10, 5));

            // Float calls!!
            Console.WriteLine("\nFloating Point Operations:");
            Console.WriteLine("Add: " + Calculate.Add(10.5f, 5.2f));
            Console.WriteLine("Subtract: " + Calculate.Subtract(10.5f, 5.2f));
            Console.WriteLine("Multiply: " + Calculate.Multiply(10.5f, 5.2f));
            Console.WriteLine("Divide: " + Calculate.Divide(10.5f, 5.2f));
        }
    }

}